@ECHO OFF
SETLOCAL
PUSHD "%~dp0."
RMDIR /S /Q ".\Package"
MKDIR ".\Package\content\Areas\MvcElmahDashboard"
XCOPY /S /E "..\ElmahDashboardHostingApp\Areas\MvcElmahDashboard" ".\Package\content\Areas\MvcElmahDashboard"
COPY "..\ElmahDashboardHostingApp\MvcElmahDashboard_Readme.html" ".\Package\content"
REN ".\Package\content\Areas\MvcElmahDashboard\Code\*.*" "*.*.pp"
REN ".\Package\content\Areas\MvcElmahDashboard\Controllers\*.*" "*.*.pp"
REN ".\Package\content\Areas\MvcElmahDashboard\Models\Home\*.*" "*.*.pp"
REN ".\Package\content\Areas\MvcElmahDashboard\Models\Logs\*.*" "*.*.pp"
REN ".\Package\content\Areas\MvcElmahDashboard\Views\Home\*.*" "*.*.pp"
REN ".\Package\content\Areas\MvcElmahDashboard\Views\Logs\*.*" "*.*.pp"
REN ".\Package\content\Areas\MvcElmahDashboard\Views\Shared\*.*" "*.*.pp"
REN ".\Package\content\Areas\MvcElmahDashboard\Views\*.*" "*.*.pp"
REN ".\Package\content\Areas\MvcElmahDashboard\*.*" "*.*.pp"
REN ".\Package\content\*.*" "*.*.pp"
FOR /R .\Package %%F IN (*.*) DO ATTRIB -r "%%F"
FOR /R .\Package %%F IN (*.pp) DO SREPLACE "%%F" /r "ElmahDashboardHostingApp" "$rootnamespace$"
COPY "..\ElmahDashboardHostingApp\web.config.install.xdt" ".\Package\content"
COPY "..\ElmahDashboardHostingApp\web.config.uninstall.xdt" ".\Package\content"
MKDIR ".\Package\tools"
COPY ".\install.ps1" ".\Package\tools"

NuGet.exe pack "Arebis.Web.Mvc.ElmahDashboard.nuspec" -BasePath "Package"

EXPLORER .

