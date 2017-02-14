var login = {};
login.click = function (obj) {
    var $this = $(obj);
    var c_array = new Array();
    //c_array.push("form-control");

    var userEmail = $("#name").val();
    var userPassword = $("#psw").val();

    var f = true;

    if (userEmail == "") {
        f = false;
        c_array.push("input_userName");
    }
    if (userPassword == "") {
        f = false;
        c_array.push("input_password");
    }

    if (!f) {
        main.showTips(c_array, "", 3000);
        return;
    }


    var baseValue = $this.val();
    var id = $this.attr("id");
    $this.val($this.attr("data-loading-text"));
    $this.attr("disabled", "disabled");

    $.ajax({
        type: "post",
        url: "/Login/DoLogin",
        data: { "userEmail": userEmail, "password": userPassword, "r": Math.random() },
        success: function (data) {
            alert("success");      
            if (data.url != "") {
                sessionStorage.user = JSON.stringify(data.DATA);
                window.location.href = data.url;
            }
            else {
                window.location.href = "/Home/Index";
            }
        },
        error: function () {
            alert("error");
            c_array = new Array();
            c_array.push(id);
            main.showTips(c_array, "", 3000);
        },
        complete: function () {
            setTimeout(function () {
                $this.val(baseValue);
                $this.removeAttr("disabled");
            }, 6000);
        }
    });
};

login.downloadLogin = function (obj) {
    var $this = $(obj);
    var c_array = new Array();
    //c_array.push("form-control");

    var userEmail = $("#input_userName").val();
    var userPassword = $("#input_password").val();

    var f = true;

    if (userEmail == "") {
        f = false;
        c_array.push("input_userName");
    }
    if (userPassword == "") {
        f = false;
        c_array.push("input_password");
    }

    if (!f) {
        main.showTips(c_array, "", 3000);
        return;
    }


    var baseValue = $this.val();
    var id = $this.attr("id");
    $this.val($this.attr("data-loading-text"));
    $this.attr("disabled", "disabled");

    $.ajax({
        type: "post",
        url: "/Login/DoDownloadLogin",
        data: { "userEmail": userEmail, "password": userPassword, "r": Math.random() },
        success: function (data) {
            window.location.href = "/Home/Download";
        },
        error: function () {
            c_array = new Array();
            c_array.push(id);
            main.showTips(c_array, "", 3000);
        },
        complete: function () {
            setTimeout(function () {
                $this.val(baseValue);
                $this.removeAttr("disabled");
            }, 6000);
        }
    });
};

login.dailyReportLogin = function (obj) {
    var $this = $(obj);
    var c_array = new Array();

    var userEmail = $("#input_userName").val();
    var userPassword = $("#input_password").val();

    var f = true;

    if (userEmail == "") {
        f = false;
        c_array.push("input_userName");
    }
    if (userPassword == "") {
        f = false;
        c_array.push("input_password");
    }

    if (!f) {
        main.showTips(c_array, "", 3000);
        return;
    }


    var baseValue = $this.val();
    var id = $this.attr("id");
    $this.val($this.attr("data-loading-text"));
    $this.attr("disabled", "disabled");

    $.ajax({
        type: "post",
        url: "/Login/DoDailyReportLogin",
        data: { "userEmail": userEmail, "password": userPassword, "r": Math.random() },
        success: function (data) {
            window.location.href = "/Home/EmployeeDailyReport";
        },
        error: function () {
            c_array = new Array();
            c_array.push(id);
            main.showTips(c_array, "", 3000);
        },
        complete: function () {
            setTimeout(function () {
                $this.val(baseValue);
                $this.removeAttr("disabled");
            }, 6000);
        }
    });
};