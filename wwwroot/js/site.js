// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // Check if the user has a saved theme preference
    if (localStorage.getItem("theme") === "light") {
        $("body").addClass("light"); // Apply light theme if saved
    }

    // Toggle the "light" class on the body and store the preference
    $(".theme-toggle").click(function () {
        $("body").toggleClass("light");

        // Save preference to localStorage
        if ($("body").hasClass("light")) {
            localStorage.setItem("theme", "light");
        } else {
            localStorage.setItem("theme", "dark");
        }
    });
});

