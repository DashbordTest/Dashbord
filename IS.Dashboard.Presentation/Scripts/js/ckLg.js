function ckLogin() {
    var name = $("#name").val();
    var psw = $("#psw").val();
    alert(name);
    $.ajax({
        type: "GET",
        url: "/Home/Test",
        data: {username:name, password:psw},
        dataType: "json",
        success: function (data) {
            if (data == 1) {
                alert("登录成功");
            }
            if (data == 0) {
                alert("登录失败");
            }
        }
    });
}