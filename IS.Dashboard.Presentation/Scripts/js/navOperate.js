function navshow(id) {
    $(document).ready(function () {
        var s_class = "." + id;
        var s_id = "#" + id;
        var val = $(s_id).val();
        if (val == 0) {
            $(".home-content").hide();
            $(s_class).show();
            $(".nav-button").val("0");
            $(s_id).val("1");
            //var newval = $(s_id).val()
        }
        if (val == 1) {
            $(s_class).hide();
            $(s_id).val("0");
            //var newval = $(s_id).val()
        } 
        });
}
function over(id) {
    var over_id = "." + id;
    $(over_id).show();
}
function out(id) {
    var out_id = "." + id;
    $(out_id).hide();
}

