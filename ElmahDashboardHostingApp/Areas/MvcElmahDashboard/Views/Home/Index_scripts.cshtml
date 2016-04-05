@{
    Layout = null;
    Response.ContentType = "application/javascript";
    Response.Cache.SetExpires(DateTime.Now.AddDays(30));
}
var hourlyOrDaily;
var autoRefresh;
var autoRefreshInterval;

$(function () {

    hourlyOrDaily = localStorage.getItem("hourlyOrDaily");
    if (hourlyOrDaily != "d") hourlyOrDaily = "h";
    $(".timespan-toggle-cmd[data-value='"+hourlyOrDaily+"']").addClass("btn-primary");

    autoRefreshInterval = localStorage.getItem("autoRefreshInterval");
    if (autoRefreshInterval == null) autoRefreshInterval = 300;
    $(".set-refresh-interval-cmd[data-value='"+autoRefreshInterval+"']").removeClass("unset");

    autoRefresh = localStorage.getItem("autoRefresh");
    if (autoRefresh == null) autoRefresh = "0";
    if (autoRefresh == "1") {
        $(".autorefresh-toggle-cmd").removeClass("unset");
    }

    $("BODY").on("click", ".autorefresh-toggle-cmd", function() {
        $(this).toggleClass("unset");
        autoRefresh = ($(this).hasClass("unset")) ? "0" : "1";
        localStorage.setItem("autoRefresh", autoRefresh);
        stopContentReload();
        if (autoRefresh == "1") reloadContent();
    });

    $("BODY").on("click", ".timespan-toggle-cmd", function() {
        window.focus();
        hourlyOrDaily = $(this).data("value");
        $(".timespan-toggle-cmd").removeClass("btn-primary");
        $(".timespan-toggle-cmd[data-value='"+hourlyOrDaily+"']").addClass("btn-primary");
        localStorage.setItem("hourlyOrDaily", hourlyOrDaily);
        stopContentReload();
        reloadContent();
    });

    $("BODY").on("click", ".refresh-now-cmd", function() {
        stopContentReload();
        reloadContent();
    });

    $("BODY").on("click", ".set-refresh-interval-cmd", function() {
        $(".set-refresh-interval-cmd").addClass("unset");
        $(this).removeClass("unset");
        autoRefreshInterval = parseInt($(this).data("value"));
        localStorage.setItem("autoRefreshInterval", autoRefreshInterval);
        if (autoRefresh == "1") {
            stopContentReload();
            reloadContent();
        }
    });

    $("BODY").on("click", "#siteDownDlg", function() {
        $(this).modal('hide');
    });

    reloadContent();

});

var reloadContentTimerId = -1;
function reloadContent() {
    var url = (hourlyOrDaily == "h") ? "@(Url.Action("HourlyStats"))" : "@(Url.Action("DailyStats"))";
    var intervalSec = autoRefreshInterval;
    $(".loader").addClass("loading");
    $(".content-header .timebar").css("animation", "none");
    $(".content-header .timebar").css("-webkit-animation", "none");
    $.ajax({
        url: url,
        cache: false,
        timeout: 10000
    })
    .always(function() {
        $(".loader").removeClass("loading");
        if (autoRefresh == "1") {
            setTimeout(function() {
                $(".content-header .timebar").css("animation", "timebar-animation " + intervalSec + "s linear");
                $(".content-header .timebar").css("-webkit-animation", "timebar-animation " + intervalSec + "s linear");
            }, 50);
            reloadContentTimerId = setTimeout(function() { reloadContent(); }, intervalSec * 1000);
        } else {
            reloadContentTimerId = -1;
        }
    })
    .done(function (data, textStatus, jqXHR) {
        $("#siteDownDlg").modal('hide');
        $("#contentholder").html(data);
        $("#contentholder").loaded();
    })
    .fail(function (jqXHR, textStatus, errorThrown) {
        $("#siteDownDlg").modal('show');
    });
}

function stopContentReload() {
    $(".content-header .timebar").css("-webkit-animation", "none");
    $(".content-header .timebar").css("animation", "none");
    if (reloadContentTimerId != -1) clearTimeout(reloadContentTimerId);
}

var heartBeatTimerId;
function heartBeat(url, intervalSec) {
    $(".heartbeat .timebar").css("animation", "none");
    $(".heartbeat .timebar").css("-webkit-animation", "none");
    $.ajax({
        url: url,
        cache: false,
        timeout: 5000
    })
    .always(function() {
        setTimeout(function() {
            $(".heartbeat .timebar").css("animation", "timebar-animation " + intervalSec + "s linear");
            $(".heartbeat .timebar").css("-webkit-animation", "timebar-animation " + intervalSec + "s linear");
        }, 50);
        heartBeatTimerId = setTimeout(function() { heartBeat(url, intervalSec); }, intervalSec * 1000);
    })
    .done(function (data, textStatus, jqXHR) {
        $(".heartbeat-failure").addClass("hidden");
        $(".heartbeat-success").removeClass("hidden");
    })
    .fail(function (jqXHR, textStatus, errorThrown) {
        $(".heartbeat-success").addClass("hidden");
        $(".heartbeat-failure").removeClass("hidden");
    });
}
