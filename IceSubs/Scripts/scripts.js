$(".container-popup").bind('keypress', function (e) {
    if (e.keyCode == 13) {
        $(".container-popup").hide();
    }
});


$(".container-popup").hide();


$("#QuitBtn").click(function () {
    $(".container-popup").hide();
});

$("#LogInBtn").click(function () {

    var div2 = $("<div/>").addClass("popup");
    var div3 = $("<div/>").addClass("LogIn");

    div2.append(div3);

    $(".container-popup").append(div3).show();



});