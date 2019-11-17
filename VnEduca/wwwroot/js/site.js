// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    $("#testMenu").click(function (e) {
        doShowMenu();
    })
})


function doShowMenu() {
 
    $(".app-drawer").addClass("opened")

    $(".app-drawer-scrim").click(function () {
        $(this).closest(".app-drawer").removeClass("opened")
    })
}