const rcoNavbar = document.getElementById("rcoNavbar");
const rcoHamburger = document.getElementById("rcoHamburger");
const rcoSidebar = document.getElementById("rcoSidebarOverlay");
const rcoBackdrop = document.getElementById("rcoBackdrop");

function checkScrollPosition() {
  if (window.scrollY > 50) {
    rcoNavbar.classList.remove("glass");
    rcoNavbar.classList.add("solid");
  } else {
    rcoNavbar.classList.remove("solid");
    rcoNavbar.classList.add("glass");
  }
}

// on scroll
window.addEventListener("scroll", checkScrollPosition);
// on page load
window.addEventListener("load", checkScrollPosition);

function toggleSidebar() {
  rcoSidebar.classList.toggle("active");
  rcoBackdrop.classList.toggle("active");
  rcoHamburger.classList.toggle("active");
}

rcoHamburger.addEventListener("click", toggleSidebar);
rcoBackdrop.addEventListener("click", toggleSidebar);

document.querySelectorAll(".rco-sidebar-overlay a").forEach(link => {
  link.addEventListener("click", () => {
    rcoSidebar.classList.remove("active");
    rcoBackdrop.classList.remove("active");
    rcoHamburger.classList.remove("active");
  });
});
