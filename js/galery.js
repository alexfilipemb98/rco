const filters = document.querySelectorAll('.filter');
  const galleryItems = document.querySelectorAll('.gallery-item');
  const lightbox = document.getElementById('lightbox');
  const lightboxImage = document.getElementById('lightboxImage');
  const lightboxClose = document.getElementById('lightboxClose');
  const arrowLeft = document.getElementById('arrowLeft');
  const arrowRight = document.getElementById('arrowRight');
  let currentIndex = 0;

  // Filtros
  filters.forEach(filter => {
    filter.addEventListener('click', () => {
      document.querySelector('.filter.active').classList.remove('active');
      filter.classList.add('active');
      const category = filter.dataset.filter;
      galleryItems.forEach(item => {
        if (category === 'all' || item.dataset.category === category) {
          item.classList.add('show');
        } else {
          item.classList.remove('show');
        }
      });
    });
  });

  const visibleItems = () => Array.from(document.querySelectorAll('.gallery-item.show img'));

  const openLightbox = index => {
    const items = visibleItems();
    currentIndex = index;
    lightboxImage.src = items[currentIndex].src.replace('/1200/1200','/2000/2000');
    lightbox.classList.add('active');
  };

  galleryItems.forEach((item, index) => {
    item.addEventListener('click', () => {
      const items = visibleItems();
      const visibleIndex = items.indexOf(item.querySelector('img'));
      openLightbox(visibleIndex);
    });
  });

  const closeLightbox = () => lightbox.classList.remove('active');

  const showPrev = () => {
    const items = visibleItems();
    currentIndex = (currentIndex - 1 + items.length) % items.length;
    lightboxImage.src = items[currentIndex].src.replace('/1200/1200','/2000/2000');
  };

  const showNext = () => {
    const items = visibleItems();
    currentIndex = (currentIndex + 1) % items.length;
    lightboxImage.src = items[currentIndex].src.replace('/1200/1200','/2000/2000');
  };

  lightboxClose.addEventListener('click', closeLightbox);
  arrowLeft.addEventListener('click', showPrev);
  arrowRight.addEventListener('click', showNext);
  lightbox.addEventListener('click', e => {
    if (e.target === lightbox) closeLightbox();
  });

  document.addEventListener('keydown', e => {
    if (!lightbox.classList.contains('active')) return;
    if (e.key === 'ArrowLeft') showPrev();
    if (e.key === 'ArrowRight') showNext();
    if (e.key === 'Escape') closeLightbox();
  });