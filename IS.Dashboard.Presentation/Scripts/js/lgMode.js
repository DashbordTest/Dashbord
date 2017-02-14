$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/lgMode",
        success: function (data) {
            alert(data);
            if (data == "authentication") {
                $(".login-bottom h3").hide();
                $(".login-bottom h3 a").hide();
            }
        }
    });
});