<!DOCTYPE html>
<!--

    ==========================================================================
    
    If in VISUAL STUDIO, right-click on this file and choose "View in Browser"
    or try Ctrl+Shift+W

    ==========================================================================

-->
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>ELMAH Dashboard</title>
    <style>
        html {
           -ms-overflow-style: scrollbar;
        }
        body {
            background: #fff;
            color: #505050;
            font: 14px 'Segoe UI', tahoma, arial, helvetica, sans-serif;
            margin: 20px;
            padding: 0;
        }

        #header {
            background: #efefef;
            padding: 0;
        }

        h1 {
            font-size: 48px;
            font-weight: normal;
            margin: 0;
            padding: 0 30px;
            line-height: 150px;
        }

        #header p {
            font-size: 20px;
            color: #fff;
            background: #969696;
            padding: 0 30px;
            line-height: 50px;
        }

        #main {
        }

        .section {
            float: left;
            position: relative;
        }

            .section h2 {
                font-size: 13px;
                text-transform: uppercase;
                margin: 0;
                border-bottom: 1px solid silver;
                padding-bottom: 12px;
                margin-bottom: 8px;
            }

            .section.left {
                margin-left: 0;
                width: 300px;
            }

                .section.left h2 {
                    font-size: 24px;
                    text-transform: none;
                    margin-bottom: 25px;
                    border: none;
                }

                .section.left li {
                    border-top: 1px solid silver;
                    padding: 8px 0;
                }

            .section.right {
                float: right;
                margin-left: 320px;

            }

        ul {
            list-style: square;
            padding-left: 18px;
            margin: 0;
            line-height: 20px;
        }

        li {
            padding: 4px 0;
        }

        a {
            color: #267cb2;
            text-decoration: none;
        }

            a:hover {
                text-decoration: underline;
            }

        .toc {
            color: #000;
            background: #EEE;
            padding: 12px;
        }

        span.marked {
            background-color: #FFFF00;
        }

        pre {
            overflow: auto;
            max-width: 800px;
        }
    </style>
    <!--<script src="http://code.jquery.com/jquery-2.1.4.min.js"></script>-->
</head>
<body>

    <div id="header">
        <h1>ELMAH Dashboard</h1>
        <p>Congratulations! You've added the ASP.NET MVC ELMAH Dashboard component</p>
    </div>

    <div id="main">

        <table cellpadding="0" cellspacing="0" border="0" width="100%">
            <tr>
                <td width="300" class="toc" valign="top">
                    <h2>Table of Content</h2>
                    <h3>Introduction</h3>
                    <h3>Prerequisites</h3>
                    <h3>Installation</h3>
                    <h3>Cultural settings</h3>
                    <h3>Heartbeat service</h3>
                    <h3>Tips</h3>
                </td>
                <td width="20"></td>
                <td valign="top">
                    <h2>Introduction</h2>
                    <p>Welcome to the <i>ELMAH Dashboard</i> ReadMe doucment.</p>
                    <p>Once installed and configured, you can copy the following link to access the <i>ELMAH Dashboard</i> pages:</p>
                    <pre style="font-size: 120%;">   <b><a href="/MvcElmahDashboard">&lt;A HREF="/MvcElmahDashboard">ELMAH Dashboard&lt;/A></a></b></pre>
                    <p>Or <a href="https://msdn.microsoft.com/en-us/library/ms178116.aspx" target="_blank">for best compatibility</a>, add the Web application root
                    operator (~) in front of the URL when inside an ASP.NET forms, view or Razor view:</p>
                    <pre style="font-size: 120%;">   <b><a href="/MvcElmahDashboard">&lt;A HREF="~/MvcElmahDashboard">ELMAH Dashboard&lt;/A></a></b></pre>

                    <h2>Prerequisites</h2>
                    <p>
                        Having the <a href="http://code.google.com/p/elmah/" target="_blank">ELMAH Error Logging Modules and Handlers for ASP.NET</a> installed
                        on this website is <i><b>not</b></i> a requirement. The <i>ELMAH Dashboard</i> shows ELMAH logs form an SQL Server
                        database. Whether those logs come from this website or from (an)other site(s) does not matter.
                    </p>
                    <p>What does matter however, is:</p>
                    <ul>
                        <li>This application hosting the <i>ELMAH Dashboard</i> must be an ASP.NET MVC web application.</li>
                        <li>The ELMAH logs to display are stored in a SQL Server database.</li>
                    </ul>
                    <h2>Installation</h2>
                    <p>You just installed the Arebis.Web.Mvc.ElmahDashboard NuGet package ? You may still have the following steps to go:</p>
                    <p><b>1.</b> Ensure the <i>ELMAH Dashboard</i>'s MVC area is configured, i.e. by having a call to</p>
                    <pre>    AreaRegistration.RegisterAllAreas();</pre>
                    <p>in the <code>Application_Start</code> method of the Global.asax's codebehind file.</p>
                    <p><b>2.</b> Configure the connection to the ELMAH database.</p>
                    <p>Ensure you have the database connection string configured in your web.config:</p>
                    <pre>    &lt;connectionstrings>
      &lt;add name="<span class="marked">whatever</span>" connectionstring="..." providername="System.Data.SqlClient" />
      ...
    &lt;/connectionstrings></pre>
                    <p>Then, write the name of the connectionstring in the AppSetting <code>MvcElmahDashboardConnectionName</code>:</p>
                    <pre>    &lt;appSettings>
      &lt;add key="MvcElmahDashboardConnectionName" value="<span class="marked">whatever</span>" />
      ...
    &lt;/appSettings></pre>
                    <p><b>3.</b> Solving the '<i>Multiple types were found that match the controller named 'Home'</i>' issue</p>
                    <p>You may now run your site (press F5) and navigate to the MvcElmahDashboard.</p>
                    <p>Chances are however that you get the following error:</p>
                    <blockquote>
                        <i>Multiple types were found that match the controller named 'Home'. This can happen if...</i>
                    </blockquote>
                    <p>To fix this issue, open the <u>App_Start/RouteConfig.cs</u> file and replace:</p>
<pre>    routes.MapRoute(
        name: "Default",
        url: "{controller}/{action}/{id}",
        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
    );
</pre>
                    <p>by:</p>
<pre>    routes.MapRoute(
        name: "Default",
        url: "{controller}/{action}/{id}",
        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }<span class="marked">,</span>
        <span class="marked">namespaces: new String[] { "ElmahDashboardHostingApp.Controllers" }</span>
    );
</pre>
                    <p>So, adding the marked code line.</p>
                    <p><b>That's it!</b> You should now be up and running. See the next sections for more configuration options.</p>
                    <h2>Cultural settings</h2>
                    <p>By default, the <i>ELMAH Dashboard</i> takes the culture of the web request on the hosting server. You can
                    however override this by forcing a culture in the Web.config using following AppSetting configuration:</p>
                    <pre>    &lt;appSettings>
      &lt;add key="MvcElmahDashboardCulture" value="<span class="marked">en-US</span>" />
      ...
    &lt;/appSettings></pre>
                    <p>The value of this setting must be a <a href="http://timtrott.co.uk/culture-codes/" target="_blank">valid
                    CultureInfo code</a>.</p>
                    <p>The Culture setting is used when rendering numbers and dates. I.e. the Culture setting determines wheter
                    dates are rendered in monyh/day/year, day/month/year or year/month/day order.</p>
                    <p>The culture in use is displayed in the page footer of the <i>ELMAH Dashboard</i>.</p>
                    
                    <h2>User Agent &amp; Geolocation information</h2>
                    <p>Error details can provide further information about the User Agent (webbrowser, robot or crawler) and geolocation
                    information about the remote address (IP address of the visitor).</p>
                    <p>User Agent information is configured by the <code>MvcElmahDashboardUserAgentInfoProvider</code> AppSetting. Remote
                    Address information is configured by the <code>MvcElmahDashboardRemoteAddressInfoProvider</code> AppSetting.</p>
                    <p>Both settings consist of a set of key/value pairs with as keys: Caption, InfoUrl and ServiceUrl. The Remote
                    Address setting can also take Latitude and Longitude keys.</p>
                    <p>The ServiceUrl must point to a service returning a flat JSON object. The Latitude and Longitude keys give the
                    name of the JSON object properties containing the latitude and longitude respectively, which is used to display
                    the location on a Google Map.</p>
                    <p>For instance, to configure the User Agent service using www.useragentstring.com:</p>
                    <pre>    &lt;appSettings>
      &lt;add key="MvcElmahDashboardUserAgentInfoProvider"
      value="<span class="marked">Caption=User Agent String.Com;InfoUrl=http://www.useragentstring.com/;ServiceUrl=http://www.useragentstring.com/?uas={value}&amp;getJSON=all</span>" />
      ...
    &lt;/appSettings></pre>
                    <p>To configure the Remote Address service using FreeGeoIP.net:</p>
                    <pre>    &lt;appSettings>
      &lt;add key="MvcElmahDashboardRemoteAddressInfoProvider"
      value="<span class="marked">Caption=FreeGeoIP.net;InfoUrl=http://freegeoip.net/;ServiceUrl=https://freegeoip.net/json/{value};Latitude=latitude;Longitude=longitude</span>" />
      ...
    &lt;/appSettings></pre>
                    <p>To configure the Remote Address service using Geobytes.com:</p>
                    <pre>    &lt;appSettings>
      &lt;add key="MvcElmahDashboardRemoteAddressInfoProvider"
      value="<span class="marked">Caption=Geobytes.com;InfoUrl=http://www.geobytes.com/iplocator/;ServiceUrl=http://getcitydetails.geobytes.com/GetCityDetails?fqcn={value};Latitude=geobyteslatitude;Longitude=geobyteslongitude</span>" />
      ...
    &lt;/appSettings></pre>
                    
                    <h2>Heartbeat service</h2>
                    <p><i>ELMAH Dashboard</i>'s dashboard has a feature to autorefresh. If you use this while
                    <i>ELMAH Dashboard</i> is running within the monitored site, you will be notified in the
                    eventuality that your site would be down. (A dialog will appear and disappear autmatically once the site
                    is up again).</p>
                    <p><b>But if the <i>ELMAH Dashboard</i> is hosted on a separate site, you may be montoring
                    your site and see no new errors appear, without being aware that your site is down!</b></p>
                    <p>The Heartbeat service is meant to solve this problem. By configuring an URL in the web.config of the
                    <i>ELMAH Dashboard</i> host, a box will appear on the dashboard showing whether the site
                    is up or down.</p>
                    <p>Add an URL of your site, for instance the site's homepage URL in following AppsSetting:</p>
                    <pre>    &lt;appSettings>
      ...
      &lt;add key="MvcElmahDashboardHeartBeatUrl" value="<span class="marked">http://www.example.com/</span>" />
      ...
    &lt;/appSettings></pre>
                    <p>By pointing to an URL that also performs a database lookup, you can monitor your database status in the same shot.</p>
                    <p>By default, this will poll your site once a minute. You can change the frequency with following AppSetting:</p>
                    <pre>    &lt;appSettings>
      ...
      &lt;add key="MvcElmahDashboardHeartBeatInterval" value="<span class="marked">00:00:30</span>" />
      ...
    &lt;/appSettings></pre>
                    <p>Here, polling is done every 30 seconds. The pollings are initiated by the browser (no monitoring browser = no
                    polling calls). But the pollings pass through the <i>ELMAH Dashboard</i> hosting web server to
                    avoid cross site request issues. The hosting web server will hereby act as a proxy and prevent excessive polling
                    to your monitored site by ignoring poll requests if a previous request is not older than half of the configured
                    interval. Hence, if polling is set to 30 seconds, your monitored website will be checked at most once every 15
                    seconds. And the status reported in a specific monitoring browser could be at most 45 seconds outdated.</p>
                    <p>Also, if the <i>ELMAH Dashboard</i> hosting web server is down, polling will stop and signal
                    an error condition.</p>
                    <p>When the <i>ELMAH Dashboard</i> is hosted within the site to monitor, this proxying or
                    redirecting has no added value and can in some cases cause issues. You can then disable the redirection by setting
                    the AppSettings <code>MvcElmahDashboardHeartBeatDirectFromBrowser</code> to true:</p>
                    <pre>    &lt;appSettings>
      ...
      &lt;add key="MvcElmahDashboardHeartBeatDirectFromBrowser" value="<span class="marked">true</span>" />
      ...
    &lt;/appSettings></pre>
                    <p>Now, polling is done directly by the browser and the server cannot cache responses anymore. Having many
                    polling browser sessions open simultaneously will therefore cause many polls.</p>
                    <p></p>

                    <h2>Tips</h2>

                    <h3>Securing the ELMAH Dashboard</h3>
                    <p>By default, the <i>ELMAH Dashboard</i> is not secured. You should therefore apply security
                    before using it on public facing (and even internal) sites.</p>
                    <p>The easiest option is to add the following section to your web.config:</p>
                    <pre>    &lt;location path="MvcElmahDashboard">
      &lt;system.web> 
        &lt;authorization> 
          &lt;allow roles="Administrators"/>
          &lt;deny users="?"/>
          &lt;deny users="*"/>
        &lt;/authorization>
      &lt;/system.web>
    &lt;/location></pre>
                    <p>This will allow only users with the 'Administrator' role on the <i>ELMAH Dashboard</i>. You will of course
                    also have to configure (forms or another) authentication form.</p>
                    <p><a href="http://weblogs.asp.net/gurusarkar/setting-authorization-rules-for-a-particular-page-or-folder-in-web-config" target="_blank">More information</a>.</p>

                    <h3>Changing the path to your ELMAH Dashboard</h3>
                    <p>By default, the <i>ELMAH Dashboard</i> is accessible under http://yoursite/<span class="marked">MvcElmahDashboard</span>.</p>
                    <p>You can change this path by changing the first path component in the area's route URL defined in the <code>RegisterArea</code> method of the <code>MvcElmahDashboardAreaRegistration</code>
                    class in de Areas\MvcElmahDashboard folder:</p>
                    <pre>public class MvcElmahDashboardAreaRegistration : AreaRegistration 
{
    public override string AreaName 
    {
        get 
        {
            return "MvcElmahDashboard";
        }
    }

    public override void RegisterArea(AreaRegistrationContext context) 
    {
        context.MapRoute(
            name: "MvcElmahDashboard_default",
            url: "<span class="marked">MvcElmahDashboard</span>/{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            namespaces: new string[] { "ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Controllers" }
        );
    }
}</pre>

                    <p>You don't need to change more. Don't change the AreaName property. (But do change the secured path form the
                    previous tip and of course your links to the <i>ELMAH Dashboard</i>).</p>

                    <h3>Adding indexes on your [ELMAH_Error] table</h3>
                    <p>To speed up searches in the ELMAH error log, try to use as much as possible the Application / Host / Source
                    / Type filters, espcially when using the searchbox to search on fulltext since fulltext search is an expensive operation.</p>
                    <p>To support the filters, it is also best to add indexes on the [ELMAH_Error] table, though note that indexes
                    speed up retrieval but slow down inserts.</p>
                    <p>Following indexes can be added to the [ELMAH_Error] table:</p>
                    <pre>    CREATE NONCLUSTERED INDEX [IX_ELMAH_Error_Application] ON [dbo].[ELMAH_Error] ([Application] ASC)
    GO
    CREATE NONCLUSTERED INDEX [IX_ELMAH_Error_Host] ON [dbo].[ELMAH_Error] ([Host] ASC)
    GO
    CREATE NONCLUSTERED INDEX [IX_ELMAH_Error_Type] ON [dbo].[ELMAH_Error] ([Type] ASC)
    GO
    CREATE NONCLUSTERED INDEX [IX_ELMAH_Error_Source] ON [dbo].[ELMAH_Error] ([Source] ASC)
    GO
    CREATE NONCLUSTERED INDEX [IX_ELMAH_Error_User] ON [dbo].[ELMAH_Error] ([User] ASC)
    GO
    CREATE NONCLUSTERED INDEX [IX_ELMAH_Error_TimeUtc] ON [dbo].[ELMAH_Error] ([TimeUtc] ASC)
    GO
    CREATE NONCLUSTERED INDEX [IX_ELMAH_Error_Sequence] ON [dbo].[ELMAH_Error] ([Sequence] ASC)
    GO</pre>
                    <p>In addition, you should regularly <a href="https://msdn.microsoft.com/en-us/library/ms189858.aspx" target="_blank">reorganize and rebuild the indexes</a>.</p>

                </td>
            </tr>
        </table>
    </div>

</body>
</html>