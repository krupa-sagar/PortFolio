/* ================================================================
   PORTFOLIO – site.js
================================================================ */

document.addEventListener('DOMContentLoaded', () => {

  // ── Navbar background on scroll ──────────────────────────────
  const nav = document.getElementById('mainNav');
  window.addEventListener('scroll', () => {
    nav.style.background = window.scrollY > 50
      ? 'rgba(15,23,42,0.98)'
      : 'rgba(15,23,42,0.92)';
  });

  // ── Smooth-scroll anchor links ───────────────────────────────
  document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', e => {
      const target = document.querySelector(anchor.getAttribute('href'));
      if (target) {
        e.preventDefault();
        target.scrollIntoView({ behavior: 'smooth', block: 'start' });
        // Collapse mobile navbar
        const collapseEl = document.getElementById('navbarNav');
        if (collapseEl && collapseEl.classList.contains('show')) {
          bootstrap.Collapse.getInstance(collapseEl)?.hide();
        }
      }
    });
  });

  // ── Skill progress bars (animate on scroll) ───────────────────
  const animateBars = () => {
    document.querySelectorAll('.skill-progress .progress-bar[data-width]').forEach(bar => {
      const rect = bar.closest('.skill-item').getBoundingClientRect();
      if (rect.top < window.innerHeight - 40 && bar.style.width === '0%') {
        bar.style.width = bar.dataset.width;
      }
    });
  };
  window.addEventListener('scroll', animateBars, { passive: true });
  animateBars(); // fire once on load

  // ── Fade-up sections on scroll ───────────────────────────────
  const fadeObserver = new IntersectionObserver(
    entries => entries.forEach(e => e.isIntersecting && e.target.classList.add('visible')),
    { threshold: 0.12 }
  );
  document.querySelectorAll('section').forEach(section => {
    section.classList.add('fade-up');
    fadeObserver.observe(section);
  });

  // ── Project filter ────────────────────────────────────────────
  document.querySelectorAll('.project-filter .btn').forEach(btn => {
    btn.addEventListener('click', () => {
      document.querySelectorAll('.project-filter .btn').forEach(b => b.classList.remove('active'));
      btn.classList.add('active');
      const filter = btn.dataset.filter;
      document.querySelectorAll('.project-item').forEach(item => {
        const show = filter === 'all' || item.classList.contains(`is-${filter}`);
        item.style.display = show ? '' : 'none';
      });
    });
  });

  // ── Bootstrap form validation ─────────────────────────────────
  document.querySelectorAll('.needs-validation').forEach(form => {
    form.addEventListener('submit', e => {
      if (!form.checkValidity()) {
        e.preventDefault();
        e.stopPropagation();
      }
      form.classList.add('was-validated');
    });
  });

  // ── Auto-scroll to contact section if ?scrollTo=contact ──────
  const params = new URLSearchParams(window.location.search);
  if (params.get('scrollTo')) {
    const el = document.getElementById(params.get('scrollTo'));
    if (el) setTimeout(() => el.scrollIntoView({ behavior: 'smooth' }), 300);
  }

});
