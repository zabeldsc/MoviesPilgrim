document.addEventListener("DOMContentLoaded", () => {
    var items = document.querySelectorAll('.item_menu');
    if (window.location.href.includes("Dashboard/Index")) {
        items[0].classList.add("select-item");
        items[1].classList.remove("select-item");
        items[2].classList.remove("select-item");
    } else if (window.location.href.includes("/Dashboard")) {
        items[0].classList.add("select-item");
        items[1].classList.remove("select-item");
        items[2].classList.remove("select-item");
    }
    else if (window.location.href.includes("Filme/Index")) {
        items[1].classList.add("select-item");
        items[0].classList.remove("select-item");
        items[2].classList.remove("select-item");
    } else if (window.location.href.includes("/Filme")){
        items[1].classList.add("select-item");
        items[0].classList.remove("select-item");
        items[2].classList.remove("select-item");
    }
    else if (window.location.href.includes("Locacoes/Index")) {
        items[2].classList.add("select-item");
        items[0].classList.remove("select-item");
        items[1].classList.remove("select-item");
    } else if(window.location.href.includes("/Locacoes")){
        items[2].classList.add("select-item");
        items[0].classList.remove("select-item");
        items[1].classList.remove("select-item");
    }
})

function navigate(el) {
    switch (el) {
        case 1:
            window.location.href = "/Dashboard/Index";
            break;
        case 2:
            window.location.href = "/Filme/Index";
            break;
        case 3:
            window.location.href = "/Locacoes/Index";
            break;
        default:
            break;
    }
}

var aux = 0;

function openSidebar() {
    aux++;
    var iconClose = document.querySelector(".close_icon");
    var items = document.querySelectorAll(".line_menu");
    const sidebar = document.querySelector("aside");

    iconClose.classList.add("active");
    items.forEach(item => {
        item.classList.add("disabled")
    })

    sidebar.classList.add("active-in")

    if (aux > 1) {
        iconClose.classList.remove('active');
        items.forEach(item => {
            item.classList.remove("disabled")
        });

        setTimeout(()=>{
            sidebar.classList.remove("active-in")
            sidebar.classList.add("disable")
        },100)
        

        aux = 0;
    }

    sidebar.classList.remove("disable")


}