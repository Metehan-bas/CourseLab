
const btn = document.getElementById("menuBtn");
const mobileMenu = document.getElementById("mobileMenu");

if (btn && mobileMenu) {
    btn.onclick = () => mobileMenu.classList.toggle("hidden");
}
function toggleMenu() {
    const menu = document.getElementById("dropdownMenu");
    const arrow = document.getElementById("arrowIcon");

    if (menu.classList.contains("hidden")) {
        menu.classList.remove("hidden");
        arrow.classList.add("rotate-180");
    } else {
        menu.classList.add("hidden");
        arrow.classList.remove("rotate-180");
    }
}

document.addEventListener("click", function (e) {
    const menu = document.getElementById("dropdownMenu");
    const button = document.querySelector('[onclick="toggleMenu()"]');
    const arrow = document.getElementById("arrowIcon");

    if (!menu.contains(e.target) && !button.contains(e.target)) {
        menu.classList.add("hidden");
        arrow.classList.remove("rotate-180");
    }
});