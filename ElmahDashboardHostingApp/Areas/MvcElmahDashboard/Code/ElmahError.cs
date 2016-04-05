using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.Linq;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Code
{
    [Table("ELMAH_Error", Schema = "dbo")]
    public class ElmahError
    {
        public int RowNum { get; set; }

        [Column]
        public virtual Guid ErrorId { get; set; }

        [Column]
        public virtual string Application { get; set; }

        [Column]
        public virtual string Host { get; set; }

        [Column]
        public virtual string Type { get; set; }

        [Column]
        public virtual string Source { get; set; }

        [Column]
        public virtual string Message { get; set; }

        [Column]
        public virtual string User { get; set; }

        [Column]
        public virtual int StatusCode { get; set; }

        [Column]
        public virtual DateTime TimeUtc { get; set; }

        public virtual TimeSpan TimeAgo
        {
            get
            {
                return (DateTime.UtcNow - this.TimeUtc);
            }
        }

        public virtual string TimeAgoText
        {
            get
            { 
                var ta = this.TimeAgo;

                if (ta.Days >= 3)
                {
                    return String.Format("{0} days ago", ta.Days, ta.Hours, ta.Minutes, ta.Seconds, ta.TotalSeconds);
                }
                else if (ta.Days >= 1)
                { 
                    return String.Format("{0} days, {1} hours ago", ta.Days, ta.Hours, ta.Minutes, ta.Seconds, ta.TotalSeconds);
                }
                else if (ta.Hours >= 12)
                {
                    return String.Format("{1} hours ago", ta.Days, ta.Hours, ta.Minutes, ta.Seconds, ta.TotalSeconds);
                }
                else if (ta.Hours >= 1)
                {
                    return String.Format("{1} hours, {2} minutes ago", ta.Days, ta.Hours, ta.Minutes, ta.Seconds, ta.TotalSeconds);
                }
                else if (ta.Minutes >= 20)
                {
                    return String.Format("{2} minutes ago", ta.Days, ta.Hours, ta.Minutes, ta.Seconds, ta.TotalSeconds);
                }
                else if (ta.Minutes >= 3)
                {
                    return String.Format("{2} minutes, {3} seconds ago", ta.Days, ta.Hours, ta.Minutes, ta.Seconds, ta.TotalSeconds);
                }
                else
                {
                    return String.Format("{4:0} seconds ago", ta.Days, ta.Hours, ta.Minutes, ta.Seconds, ta.TotalSeconds);
                }
            }
        }

        [Column]
        public virtual int Sequence { get; set; }

        [Column]
        public virtual XDocument AllXml { get; set; }

        public virtual string ErrorDetail
        {
            get
            {
                return (AllXml.Root.Attribute("detail") != null) ? AllXml.Root.Attribute("detail").Value : "No details...";
            }
        }

        public virtual IDictionary<string, string> ServerVariables
        {
            get
            {
                return GetXmlDictionary("serverVariables");
            }
        }

        public virtual IDictionary<string, string> FormFields
        {
            get
            {
                return GetXmlDictionary("form");
            }
        }

        public virtual IDictionary<string, string> Cookies
        {
            get
            {
                return GetXmlDictionary("cookies");
            }
        }

        private IDictionary<string, string> GetXmlDictionary(string element)
        {
            if (AllXml.Root.Element(element) != null)
            {
                return AllXml.Root.Element(element).Elements("item")
                    .ToDictionary(i => i.Attribute("name").Value, i => (i.Element("value") == null) ? "" : i.Element("value").Attribute("string").Value);
            }
            else
            {
                return new Dictionary<string, string>();
            }
        }
    }
}
