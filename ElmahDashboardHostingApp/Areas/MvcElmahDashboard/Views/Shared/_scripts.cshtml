@{
    Layout = null;
    Response.ContentType = "application/javascript";
    Response.Cache.SetExpires(DateTime.Now.AddDays(30));
}
$(function() {

    /// Support for:
    /// <a href="null">Do nothing</a>
    $(document.body).on('click', "A[href='null']", function (event) {
        event.preventDefault();
    });

    /// Support for:
    /// <a href="histroy:back">Go Back</a>
    $(document.body).on('click', "A[href='history:back']", function(event) {
        history.back();
        event.preventDefault();
    });

    /// Provides an alternative anchor href that can contain form field values.
    /// The data-href should contain the href where form field id's are written between brackets.
    /// If all referenced form fields are empty, the regular href is used.
    /// Tip: to include values from the query string, copy those values in a hidden field and reference
    ///      the field; see the data-init-queryfield extension.
    /// For instance, the following will perform a search on Google:
    /// <input id="searchtext" type="text" />
    /// <a href="http://www.google.com/" data-href="http://www.google.com/search?q={searchtext}" target="_blank">Google</a>
    $(document.body).on('click', "A[data-href]", function (event) {

        var pattern = /{(.*?)}/g;
        var althref = $(this).data('href');
        var useralthref = false;

        // https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String/replace
        var althrefsubst = althref.replace(pattern, function (match, fieldname) {
            var value = $('#' + fieldname).val();
            if (value) useralthref = true;
            return value;
        });

        if (useralthref) {
            event.preventDefault();

            var target = $(this).attr("target");
            if (!target) target = '_self';
            window.open(althrefsubst, target);
        }
    });

    /// Support for forwarding click events. I.e. a click on the div will be translated into
    /// a click on the link:
    ///
    ///   <div data-forward-click="#a1">Click me!</div>
    ///   <a id="a1" href="http://www.example.com/">...</a>
    ///
    $(document.body).on('click', "*[data-forward-click]", function(event) {
        $($(this).data('forward-click'))[0].click(); // See: http://goo.gl/lGftqn
        event.preventDefault();
    });

    /// Rendering and behavior of 'back-top' control for fast scrolling-up to top of page.
    /// Usage: simply include the following html in your page('s template), no matter where:
    ///
    ///   <a id="back-top" href="#top">
    ///       <i class="glyphicon glyphicon-chevron-up"></i>
    ///   </a>
    ///
    /// On top of the page, you can place a '<a name="top"></a>' to support javascript-less browsers, but this is
    /// not required for javascript supporting browsers.
    $("#back-top").hide();
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('#back-top').fadeIn(800);
        } else {
            $('#back-top').fadeOut(400);
        }
    });
    // scroll body to 0px on click
    $('#back-top').click(function () {
        $('body,html').animate({
            scrollTop: 0
        }, 500);
        return false;
    });

    $(document.body).loaded();

    setInterval(function() {
        $("#clock-text").text(new Date().toLocaleString());
    }, 1000);

});

jQuery.fn.extend({
    loaded: function() {

        // For any element having a 'data-moveto': moves the content HTML to the given selector.
        $(this).find("*[data-moveto]").each(function() {
            $($(this).data("moveto")).html($(this).html());
            $($(this).data("moveto")).loaded();
            $(this).html('');
        });


        /// Initializes the input element's value with the named field from the query string.
        /// I.e: http://.../...?searchquery=What+I+am+searching+for
        ///      <input name="searchquery" data-init-queryfield="searchquery" type="text" />
        $(this).find('INPUT[data-init-queryfield]').each(function () {
            var paramname = $(this).data("init-queryfield");
            var match = RegExp('[?&]' + paramname + '=([^&]*)').exec(window.location.search);
            var value = match ? decodeURIComponent(match[1].replace(/\+/g, ' ')) : null;

            $(this).val(value);
        });

        /// For any element having a 'data-utctime' value, render the value as local date/time.
        /// Either using the .toLocaleString() method, or, if a 'data-format' attribute is present,
        /// using custom formatting.
        $(this).find("*[data-utctime]").each(function(index, item) {
            var d = new Date(parseInt($(item).data("utctime"))).getLocalTime();
            var f = $(item).data("format");
            if (f === undefined) {
                $(item).html(d.toLocaleString());
            } else {
                $(item).html(d.format(f));
            }
        });

        /// For any element having a 'data-load-url': load the given URL:
        /// Optionally, a 'data-load-refresh' indicates the time (in seconds) after which to continuously refresh the content.
        /// The url can contain a "{rnd}" literal that will then be replaced by a random number to force reloading.
        /// I.e: <div data-load-url="/DebugInfo.aspx?x={rnd}" data-load-refresh="10"></div>
        $(this).find("*[data-load-url]").each(function () {
            var url = $(this).data("load-url") + '';
            var target = $(this);
            target.load(url.replace('{rnd}', Math.random()), function() { target.loaded(); });
            if ($(this).data("load-refresh")) {
                window.setInterval(function () { target.load(url.replace('{rnd}', Math.random()), function() { target.loaded(); }); }, $(this).data("load-refresh") * 1000);
            }
        });

        $(this).find("CANVAS:has(> TABLE)").each(function() {
            drawGraph($(this));
        });
    }
});

/// Converts an UTC date/time to browser's local date/time.
Date.prototype.getLocalTime = function() {
    return new Date(this.getTime() + 60 * this.getTimezoneOffset());
}

/// Formats a Date object based on the given formatstring.
Date.prototype.format = function(format) {
    var s = format;
    s = s.replace("DD", ("0"+(this.getDate())).substr(-2));
    s = s.replace("D", (this.getDate()));
    s = s.replace("MM", ("0"+(this.getMonth()+1)).substr(-2));
    s = s.replace("M", (this.getMonth()+1));
    s = s.replace("YYYY", (this.getFullYear()));
    s = s.replace("YY", ("0"+(this.getYear()%100)).substr(-2));
    s = s.replace("hh", ("0"+(this.getHours())).substr(-2));
    s = s.replace("mm", ("0"+(this.getMinutes())).substr(-2));
    s = s.replace("ss", ("0"+(this.getSeconds())).substr(-2));
    s = s.replace("mmm", ("00"+(this.getMilliseconds())).substr(-3));
    return s;
}

// https://developer.mozilla.org/en-US/docs/Web/API/Canvas_API/Tutorial
function drawGraph(canvas) {
    var table = canvas.find('TABLE');
    var can = canvas[0];

    if (can.getContext) {
        // Initialize canvas:
        var ctx = can.getContext('2d');
        if (canvas.data("background")) {
            ctx.fillStyle = canvas.data("background");
            ctx.fillRect(0,0,can.width,can.height);
        }
        // Find highest graph value:
        var topv = 20.0;
        table.find("TD").each(function(index, item) { topv = Math.max(topv, parseFloat($(item).text())) }); 
        // Draw bars:
        table.find("TR[data-graph-style='bars']").each(function(rowindex, row) {
            var cellCount = $(row).find("TD").length;
            var cellWidth = can.width / (cellCount + 1);
            $(row).find("TD").each(function(cellindex, cell) {
                if ($(cell).data("fill-style")) ctx.fillStyle = $(cell).data("fill-style");
                var value = parseFloat($(cell).text());
                ctx.fillRect(cellWidth + cellindex * cellWidth, can.height, cellWidth - 4, -(value / topv * can.height + 2));
            });
        });
        // Draw axes:
        if (canvas.data("fill-style")) {
            ctx.fillStyle = canvas.data("fill-style");
        } else {
            ctx.fillStyle = "#000";
        }
        if (canvas.data("font")) {
            ctx.font = canvas.data("font");
        }
        ctx.fillText('' + (topv), 0.5, 24.5);
        ctx.fillText('' + (topv / 2), 0.5, 161.5);
        ctx.fillText('0', 0.5, 299.5);
    }
}