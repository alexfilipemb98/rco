
// Theme & basics
(function () {
  const body = document.body;
  const saved = localStorage.getItem('rco-theme');
  // limpar classes antigas
  body.classList.remove('theme-light', 'theme-dark');
  if (saved === 'theme-light') {
    body.classList.add('theme-light');
  } else if (saved === 'theme-dark') {
    // nada: base já é dark
  } else if (window.matchMedia && window.matchMedia('(prefers-color-scheme: light)').matches) {
    body.classList.add('theme-light');
  }
  const year = document.getElementById('year');
  if (year) year.textContent = new Date().getFullYear();
})();

// Drawer
(function(){
  const burger = document.getElementById('burger');
  const drawer = document.getElementById('drawer');
  const scrim = document.getElementById('scrim');
  if(!burger || !drawer || !scrim) return;

  const open = ()=>{
    drawer.classList.add('open');
    scrim.classList.add('show');
    burger.classList.add('open');
    burger.setAttribute('aria-expanded','true');
  };

  const close = ()=>{
    drawer.classList.remove('open');
    scrim.classList.remove('show');
     burger.classList.remove('open');
    burger.setAttribute('aria-expanded','false');
  };

  // Toggle ao clicar no ícone
  burger.addEventListener('click', ()=> drawer.classList.contains('open') ? close() : open());

  // Fechar ao clicar fora
  scrim.addEventListener('click', close);

  // Fechar ao carregar ESC
  document.addEventListener('keydown', e=>{ if(e.key==='Escape') close(); });

  // 🔥 Fechar ao clicar num link do menu lateral
  drawer.querySelectorAll('a').forEach(link=>{
    link.addEventListener('click', ()=>{
      close();
    });
  });
})();

// Tema (ícone simples)
(function () {
  const btn = document.getElementById('themeToggle');
  if (!btn) return;

  function isLight() {
    return document.body.classList.contains('theme-light');
  }

  function apply(light) {
    document.body.classList.toggle('theme-light', light);
    localStorage.setItem('rco-theme', light ? 'theme-light' : 'theme-dark');
    btn.textContent = light ? '☀️' : '🌙';

    const meta = document.querySelector('meta[name="theme-color"]');
    if (meta) {
      meta.setAttribute('content', light ? '#0b6cff' : '#020617');
    }
  }

  // aplica ícone e meta com base no estado actual
  apply(isLight());

  btn.addEventListener('click', () => {
    apply(!isLight());
  });
})();

// Scrollspy do menu (single page)
(function () {
  const links = Array.from(document.querySelectorAll('.nav.desktop a[href^="#"], .drawer-nav a[href^="#"]'));
  if (!links.length) return;

  const sections = links
    .map(a => {
      const id = a.getAttribute('href').slice(1);
      const el = document.getElementById(id);
      return el ? { link: a, section: el } : null;
    })
    .filter(Boolean);

  function setActive(targetId) {
    links.forEach(a => a.classList.toggle('is-active', a.getAttribute('href') === '#' + targetId));
  }

  function onScroll() {
    const fromTop = window.scrollY + 120; // offset do header
    let currentId = 'inicio';

    for (const { section } of sections) {
      if (section.offsetTop <= fromTop) {
        currentId = section.id;
      }
    }
    setActive(currentId);
  }

  window.addEventListener('scroll', onScroll, { passive: true });
  window.addEventListener('load', onScroll);
})();

// Reveal on scroll
(function () {
  const els = document.querySelectorAll('.reveal');
  if (!('IntersectionObserver' in window)) { els.forEach(e => e.classList.add('visible')); return; }
  const io = new IntersectionObserver(entries => {
    entries.forEach(ent => {
      if (ent.isIntersecting) { ent.target.classList.add('visible'); io.unobserve(ent.target); }
    });
  }, { threshold: 0.2 });
  els.forEach(e => io.observe(e));
})();

// Lightbox gallery
(function () {
  const thumbs = Array.from(document.querySelectorAll('[data-gallery]'));
  if (!thumbs.length) return;
  const lb = document.getElementById('lightbox');
  const img = lb.querySelector('.lb-img');
  const btnPrev = lb.querySelector('.lb-prev');
  const btnNext = lb.querySelector('.lb-next');
  const btnClose = lb.querySelector('.lb-close');
  let i = 0, touchX = 0;

  function show(idx) {
    i = (idx + thumbs.length) % thumbs.length;
    img.src = thumbs[i].src;
    lb.classList.add('show');
    lb.setAttribute('aria-hidden', 'false');
    // bloquear scroll da página
    document.body.classList.add('no-scroll');

  }
  function hide() {
    lb.classList.remove('show');
    lb.setAttribute('aria-hidden', 'true');
    // bloquear scroll da página
    document.body.classList.remove('no-scroll');

  }

  thumbs.forEach((t, idx) => t.addEventListener('click', () => show(idx)));
  btnClose.addEventListener('click', hide);
  btnPrev.addEventListener('click', () => show(i - 1));
  btnNext.addEventListener('click', () => show(i + 1));
  lb.addEventListener('click', e => { if (e.target === lb) hide(); });
  document.addEventListener('keydown', e => {
    if (!lb.classList.contains('show')) return;
    if (e.key === 'Escape') hide();
    if (e.key === 'ArrowLeft') show(i - 1);
    if (e.key === 'ArrowRight') show(i + 1);
  });
  lb.addEventListener('touchstart', e => { touchX = e.changedTouches[0].clientX; }, { passive: true });
  lb.addEventListener('touchend', e => {
    const dx = e.changedTouches[0].clientX - touchX;
    if (Math.abs(dx) > 40) { dx > 0 ? show(i - 1) : show(i + 1); }
  }, { passive: true });
})();

// Cookie banner
(function(){
  const banner = document.getElementById('cookieBanner');
  const btn = document.getElementById('acceptCookies');
  if(!banner || !btn) return;

  const accepted = localStorage.getItem('cookiesAccepted');
  if(accepted){
    banner.classList.add('hide');
    return;
  }

  btn.addEventListener('click', ()=>{
    localStorage.setItem('cookiesAccepted', 'true');
    banner.classList.add('hide');
  });
})();