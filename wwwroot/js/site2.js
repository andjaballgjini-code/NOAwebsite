// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.querySelectorAll('.dropdown-submenu .dropdown-toggle').forEach(function (element) {
    element.addEventListener('click', function (e) {
        e.stopPropagation();
        e.preventDefault();
        let submenu = this.nextElementSibling;
        if (submenu) {
            submenu.classList.toggle('show');
        }
    });
});
