
// Theme toggle with persistence
(function(){
  const body = document.body;
  const saved = localStorage.getItem('rco-theme');
  if(saved){ body.classList.add(saved); }
  else{
    if(window.matchMedia && window.matchMedia('(prefers-color-scheme: light)').matches){
      body.classList.add('theme-light');
    }
  }
  const y = document.getElementById('year'); if(y) y.textContent = new Date().getFullYear();
  // before-after sliders
  document.querySelectorAll('.ba').forEach(el=>{
    const range = el.querySelector('.ba-range');
    const set = (v)=>{ el.style.setProperty('--pos', v+'%'); };
    if(range){ set(range.value); range.addEventListener('input', e=> set(e.target.value)); }
  });
  // scroll reveal
  const io = new IntersectionObserver((entries)=>{
    for(const ent of entries){
      if(ent.isIntersecting){ ent.target.classList.add('visible'); io.unobserve(ent.target); }
    }
  }, {threshold: .2});
  document.querySelectorAll('.reveal').forEach(r=> io.observe(r));
})();

// Drawer toggle
(function(){
  const burger = document.getElementById('burger');
  const drawer = document.getElementById('drawer');
  const scrim = document.getElementById('scrim');
  if(!burger || !drawer) return;
  function open(){ drawer.classList.add('open'); scrim.classList.add('show'); burger.setAttribute('aria-expanded','true'); drawer.setAttribute('aria-hidden','false'); }
  function close(){ drawer.classList.remove('open'); scrim.classList.remove('show'); burger.setAttribute('aria-expanded','false'); drawer.setAttribute('aria-hidden','true'); }
  burger.addEventListener('click', ()=> drawer.classList.contains('open') ? close() : open());
  scrim.addEventListener('click', close);
  document.addEventListener('keydown', (e)=>{ if(e.key==='Escape') close(); });
})();

// Theme switch as checkbox
(function(){
  const chk = document.getElementById('themeSwitch');
  if(!chk) return;
  const isLight = document.body.classList.contains('theme-light');
  chk.checked = isLight;
  chk.addEventListener('change', ()=>{
    const light = chk.checked;
    document.body.classList.toggle('theme-light', light);
    localStorage.setItem('rco-theme', light ? 'theme-light' : 'theme-dark');
  });
})();


// v4: ensure theme switch reflects state on load and clicking anywhere on label toggles
(function(){
  const chk = document.getElementById('themeSwitch');
  const label = document.querySelector('.switch');
  if(!chk || !label) return;
  const isLight = document.body.classList.contains('theme-light');
  chk.checked = isLight;
  label.addEventListener('click', (e)=>{
    if(e.target.tagName.toLowerCase() !== 'input'){ chk.checked = !chk.checked; chk.dispatchEvent(new Event('change')); }
  });
})();

// Lightbox gallery (click, arrows, swipe)
(function(){
  const imgs = Array.from(document.querySelectorAll('[data-gallery]'));
  if(imgs.length===0) return;
  const lb = document.getElementById('lightbox');
  const img = lb.querySelector('.lb-img');
  const btnPrev = lb.querySelector('.lb-prev');
  const btnNext = lb.querySelector('.lb-next');
  const btnClose = lb.querySelector('.lb-close');
  let i = 0, touchX=0;

  function show(idx){
    i = (idx + imgs.length) % imgs.length;
    img.src = imgs[i].src;
    lb.classList.add('show');
    lb.setAttribute('aria-hidden','false');
  }
  function hide(){ lb.classList.remove('show'); lb.setAttribute('aria-hidden','true'); }

  imgs.forEach((el,idx)=> el.addEventListener('click', ()=> show(idx)));
  btnClose.addEventListener('click', hide);
  btnPrev.addEventListener('click', ()=> show(i-1));
  btnNext.addEventListener('click', ()=> show(i+1));
  lb.addEventListener('click', (e)=>{ if(e.target===lb) hide(); });
  document.addEventListener('keydown', (e)=>{
    if(!lb.classList.contains('show')) return;
    if(e.key==='Escape') hide();
    if(e.key==='ArrowLeft') show(i-1);
    if(e.key==='ArrowRight') show(i+1);
  });
  lb.addEventListener('touchstart', e=>{ touchX = e.changedTouches[0].clientX; }, {passive:true});
  lb.addEventListener('touchend', e=>{
    const dx = e.changedTouches[0].clientX - touchX;
    if(Math.abs(dx)>40){ dx>0 ? show(i-1) : show(i+1); }
  }, {passive:true});
})();
