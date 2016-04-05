@{
    Layout = null;
    Response.ContentType = "application/javascript";
    Response.Cache.SetExpires(DateTime.Now.AddDays(30));
}
$(function () {

    /// Initializes the select element's value with the named field from the query string.
    /// I.e: http://.../...?searchquery=What+I+am+searching+for
    ///      <select name="searchquery" data-init-queryfield="searchquery">...</select>
    $('SELECT[data-init-queryfield]').each(function () {
        var paramname = $(this).data("init-queryfield");
        var match = RegExp('[?&]' + paramname + '=([^&]*)').exec(window.location.search);
        var value = match ? decodeURIComponent(match[1].replace(/\+/g, ' ')) : null;
        if (value != null) $(this).val(value);
    });

    $(".reload-on-change").on('change', function () {
        reloadData();
    });

    $(".reload-on-click").on('click', function () {
        reloadData();
    });

    $("BODY").on('click', '.nav-list-first', function () {
        $("INPUT[name='offset']").val(0);
        reloadData();
    });

    $("BODY").on('click', '.nav-list-prev', function () {
        var offset = parseInt($("INPUT[name='offset']").val()) - parseInt($("SELECT[name='length']").val());
        if (offset < 0) offset = 0;
        $("INPUT[name='offset']").val(offset);
        reloadData();
    });

    $("BODY").on('click', '.nav-list-next', function () {
        var offset = parseInt($("INPUT[name='offset']").val()) + parseInt($("SELECT[name='length']").val());
        $("INPUT[name='offset']").val(offset);
        reloadData();
    });

    reloadData();
});

function reloadData() {
    var args = {
        offset: $("INPUT[name='offset']").val(),
        length: $("SELECT[name='length']").val(),
        application: $("SELECT[name='application']").val(),
        host: $("SELECT[name='host']").val(),
        source: $("SELECT[name='source']").val(),
        type: $("SELECT[name='type']").val(),
        search: $("INPUT#search").val()
    };
    $(".loader").addClass("loading");
    $.ajax({
        url: "@(Url.Action("Items"))",
        data: args,
        cache: false
    })
    .always(function () {
        $(".loader").removeClass("loading");
    }).done(function (result) {
        $("#list-content").html(result);
        $("#list-content").loaded();
    }).fail(function () {
        alert('Loading list of errors failed.\r\nRefresh to retry.');
    });
}
