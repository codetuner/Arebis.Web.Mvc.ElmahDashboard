using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Code
{
    [Table("ELMAH_Error", Schema = "dbo")]
    public class ElmahErrorItem
    {
        public int RowNum { get; set; }

        [Column]
        public virtual int Sequence { get; set; }

        [Column]
        public virtual string Application { get; set; }

        [Column]
        public virtual DateTime TimeUtc { get; set; }
    }
}