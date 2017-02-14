var user = JSON.parse(sessionStorage.user);

var viewModel = {
    showBulk: ko.observable(false),
    showWaag: ko.observable(false),
    showHome: ko.observable(true),
    clickBulk: function () {
        viewModel.showWaag(false);
        viewModel.showHome(false);
        viewModel.showBulk(true);
        $("#navigation li:gt(1)").hide();
        $("#navigation li:lt(2)").show();
    },
    clickHome: function () {
        viewModel.showWaag(false);
        viewModel.showBulk(false);
        viewModel.showHome(true);
        $("#navigation li:gt(0)").hide();
    },
    clickWaag: function () { 
        viewModel.showWaag(true);
        viewModel.showBulk(false);
        viewModel.showHome(false);
        $("#navigation li:gt(0)").show();
    }
};

$(document).ready(function () {
    if(user)
    {
        $('#username').text(user.FirstName + ',' + user.LastName);
    }

    $("#navigation li:gt(0)").hide();
});