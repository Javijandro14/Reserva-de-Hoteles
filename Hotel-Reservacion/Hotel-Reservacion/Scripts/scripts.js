function load() {

    var head = document.querySelector("title");
    head.innerHTML = document.querySelector("#page").innerHTML;
    var table = document.querySelector(".contenedor");
    if (table != undefined) table.style.margin = "0px 3% 0px 3%";
    var nav = document.querySelector(".navbar.navbar-default");
    nav.style.paddingBottom = "2em";
    nav.style.paddingLeft = "1em";
    nav.style.paddingRight = "1em";
    document.querySelector(".dxmLite.dxm-ltr").style.fontSize = "15px";
}