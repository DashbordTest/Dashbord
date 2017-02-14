function stretch() {
    $(document).ready(function () {
        $(".default-index-nav").hide();
        $(".index-nav").show();
        $("#index-content").removeClass("default-index-content").addClass("index-content");
    });
}

function indent() {
    $(document).ready(function () {
        $(".index-nav").hide();
        $(".default-index-nav").show();
        $("#index-content").removeClass("index-content").addClass("default-index-content");
    });
}
function detailshow(thisobj) {
    $(document).ready(function () {
        var $this = $(thisobj);
        var tname = $this.attr("tname");
        var _thisName = "";
        if (tname == undefined) {
            _thisName = $this.text().trim();
        }
        else {
            _thisName = tname;
        }
        var html = $("#navigation").html();
        var x = "<li>" + _thisName + "</li>";
        $("#navigation").html(html + x);
        var preli = $("#navigation li").last().prev();
        preli.addClass("activenav");
        preli.click(function () {
            var navli = preli.text();
            navli = navli.replace(/\s/ig, '');
            var navshow = "." + navli;
            $(".uniform").hide();
            $(navshow).show();
            preli.removeClass("activenav");
            preli.nextAll().remove();
            preli.unbind("click");
        });
        _thisName = _thisName.replace(/\s/ig, '');
        var navdetail = "." + _thisName;
        //alert(navdetail);
        $(".uniform").hide();
        $(navdetail).show();
    });
}
