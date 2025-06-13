const slides = document.querySelectorAll('.hero-slide');
let currentSlide = 0;

function showSlide(index) {
  slides.forEach(slide => slide.classList.remove('active'));
  slides[index].classList.add('active');
}

function nextSlide() {
  currentSlide = (currentSlide + 1) % slides.length;
  showSlide(currentSlide);
}

setInterval(nextSlide, 5000);

const items = document.querySelectorAll('.rco-gallery-item');
const lightbox = document.getElementById('rcoLightbox');
const lbImg = lightbox.querySelector('.rco-lightbox-img');
const lbClose = lightbox.querySelector('.rco-lightbox-close');

// Abre lightbox com imagem clicada
items.forEach(item => {
  item.addEventListener('click', e => {
    e.preventDefault();
    lbImg.src = item.href;
    lightbox.classList.add('active');
  });
});

// Fechar ao clicar “X” ou fora da imagem
lbClose.addEventListener('click', () => lightbox.classList.remove('active'));
lightbox.addEventListener('click', e => {
  if (e.target === lightbox) {
    lightbox.classList.remove('active');
  }
});
