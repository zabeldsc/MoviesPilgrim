// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


if (window.location.href.includes('Login')) {
    var link = document.querySelector("link[rel~='shortcut icon']");
    link.href = 'icon_white_black_mini.ico';
  }