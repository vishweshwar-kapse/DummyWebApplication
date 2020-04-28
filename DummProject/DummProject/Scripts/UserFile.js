$(document).ready(function () {
    $.ajax({
        contentType: "application/json; charset=utf-8",
        url: "http://localhost:6212/UserService.asmx/HelloWorld",
        data: { value: 2 },
        success: function (json) {
            alert("got the message" + json.d);
        },
        error: function (err) {
            var x = err;
        }
    });
});