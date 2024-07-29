$(document).ready(function () {
    const urlParams = new URLSearchParams(window.location.search);
    const myParam = urlParams.get('h');
    const divs = document.getElementsByTagName("div");
    for (const el of divs) {
        el.style.height = myParam;
    }
});