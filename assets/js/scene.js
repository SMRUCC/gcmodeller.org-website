/* ============================================================
 *  GCModeller homepage — "Life Factor · Knowledge Network"
 *  Scene: low-poly living factor + orbiting knowledge network
 *  + mouse-as-light + whole-assembly tilt. (port of web_life_factor V2)
 * ============================================================ */
import * as THREE from 'three';

/* ---------- knowledge nodes: life-AI concepts ---------- */
const NODES = [
  { name: 'Virtual Cell',          tag: 'Modeling',  hub: true,  desc: 'A computational replica of living cellular physiology: reconstruct metabolism, regulation and signaling, then run experiments in silico before touching the bench.' },
  { name: 'Synthetic Biology',     tag: 'Design',    hub: true,  desc: 'Designing biological parts, devices and systems with engineering principles — computer-assisted design applied to life itself.' },
  { name: 'Systems Biology',       tag: 'Modeling',  hub: false, desc: 'Treating the cell as an integrated network of interacting components, where emergent behavior cannot be explained gene by gene.' },
  { name: 'Genomics',              tag: 'Data',      hub: false, desc: 'Sequencing the blueprint of life — assembly, annotation and comparative analysis of genomes at population and ecosystem scale.' },
  { name: 'Gene Regulation',       tag: 'Modeling',  hub: false, desc: 'The wiring diagram of transcription factors and their targets: the logic that lets one genome produce hundreds of distinct cell states.' },
  { name: 'Metabolic Modeling',    tag: 'Modeling',  hub: false, desc: 'Flux balance analysis converts network stoichiometry into testable predictions of growth rates and secretion profiles.' },
  { name: 'Neural Networks',       tag: 'AI',        hub: false, desc: 'Graph and neural models — GNN, LNN, neural ODEs — learn the hidden logic of living systems directly from high-throughput measurements.' },
  { name: 'Genome Annotation',     tag: 'Pipeline',  hub: false, desc: 'ORF prediction, homology search, HMM profiling and motif discovery turn raw sequence into functional knowledge.' },
  { name: 'Multi-Omics',           tag: 'Data',      hub: false, desc: 'Integrating transcriptome, proteome, metabolome and microbiome layers into one coherent picture of a cell at work.' },
  { name: 'Transcriptomics',       tag: 'Omics',     hub: false, desc: 'Measuring every mRNA the cell chooses to express — the first readout of both natural and virtual perturbations.' },
  { name: 'Proteomics',            tag: 'Omics',     hub: false, desc: 'The working machinery of the cell: abundance, interaction and modification of the complete protein complement.' },
  { name: 'Metagenomics',          tag: 'Omics',     hub: false, desc: 'Reading the collective genome of microbial communities that shape health, environment and fermentation.' },
  { name: 'Metabolomics',          tag: 'Omics',     hub: false, desc: 'The layer closest to the phenotype — small molecules that report what the cell is actually doing right now.' },
  { name: 'Perturbation Analysis', tag: 'Simulation',hub: false, desc: 'Knock out a gene or over-express a pathway in the virtual cell first — then validate only the most promising designs at the bench.' },
  { name: 'Pathway Enrichment',    tag: 'Analysis',  hub: false, desc: 'GSEA, GSVA and over-representation analysis translate gene lists into biological meaning on KEGG and GO maps.' },
  { name: 'R# Language',           tag: 'Interface', hub: true,  desc: 'A dynamic scripting language for scientific computing — the single interface that drives every GCModeller workflow.' },
];
const N = NODES.length;

/* ---------- renderer / scene / camera ---------- */
const canvas = document.getElementById('scene');
const renderer = new THREE.WebGLRenderer({ canvas, antialias: true });
renderer.setPixelRatio(Math.min(window.devicePixelRatio, 2));
renderer.setSize(window.innerWidth, window.innerHeight);
renderer.outputColorSpace = THREE.SRGBColorSpace;
renderer.toneMapping = THREE.ACESFilmicToneMapping;
renderer.toneMappingExposure = 1.1;

const scene = new THREE.Scene();
scene.background = new THREE.Color('#0a0d12');
scene.fog = new THREE.Fog('#0a0d12', 10, 17);

const camera = new THREE.PerspectiveCamera(44, window.innerWidth / window.innerHeight, 0.1, 60);
camera.position.set(0, 0.05, 7.4);

const stage = new THREE.Group();
scene.add(stage);

/* ---------- lights: the mouse is the key light ---------- */
scene.add(new THREE.HemisphereLight('#44546f', '#0a0d13', 0.62));
const fill = new THREE.DirectionalLight('#5f7ea8', 0.62);
fill.position.set(-5, 3, 4);
scene.add(fill);

const mouseLight = new THREE.PointLight('#ffe7cf', 60, 0, 2);
scene.add(mouseLight);

function makeGlow() {
  const c = document.createElement('canvas'); c.width = c.height = 256;
  const ctx = c.getContext('2d');
  const g = ctx.createRadialGradient(128, 128, 0, 128, 128, 128);
  g.addColorStop(0,   'rgba(255,244,228,0.85)');
  g.addColorStop(0.25,'rgba(255,214,180,0.28)');
  g.addColorStop(0.6, 'rgba(255,190,160,0.07)');
  g.addColorStop(1,   'rgba(255,190,160,0)');
  ctx.fillStyle = g; ctx.fillRect(0, 0, 256, 256);
  const tex = new THREE.CanvasTexture(c);
  const spr = new THREE.Sprite(new THREE.SpriteMaterial({
    map: tex, transparent: true, blending: THREE.AdditiveBlending, depthWrite: false, opacity: 0.55
  }));
  spr.scale.set(1.9, 1.9, 1);
  return spr;
}
const glow = makeGlow();
scene.add(glow);

/* ---------- background stardust ---------- */
function makeStars() {
  const n = 460;
  const pos = new Float32Array(n * 3), col = new Float32Array(n * 3);
  const v = new THREE.Vector3(), c = new THREE.Color();
  for (let i = 0; i < n; i++) {
    v.randomDirection().multiplyScalar(7 + Math.random() * 8);
    pos[i * 3] = v.x; pos[i * 3 + 1] = v.y; pos[i * 3 + 2] = v.z;
    const b = 0.25 + Math.random() * 0.75;
    c.setHSL(0.58 + (Math.random() - 0.5) * 0.06, 0.25, 0.3 + b * 0.42);
    col[i * 3] = c.r; col[i * 3 + 1] = c.g; col[i * 3 + 2] = c.b;
  }
  const g = new THREE.BufferGeometry();
  g.setAttribute('position', new THREE.BufferAttribute(pos, 3));
  g.setAttribute('color', new THREE.BufferAttribute(col, 3));
  const p = new THREE.Points(g, new THREE.PointsMaterial({
    size: 0.05, sizeAttenuation: true, vertexColors: true,
    transparent: true, opacity: 0.9, depthWrite: false
  }));
  p.frustumCulled = false;
  return p;
}
const stars = makeStars();
scene.add(stars);

/* ============================================================
 *  Life factor: low-poly organism with breathing tentacles
 * ============================================================ */
function makeBlob() {
  const geo = new THREE.IcosahedronGeometry(1, 2);
  const posA = geo.attributes.position;
  const count = posA.count;

  const map = new Map(), uDirs = [], dirIdx = new Int32Array(count);
  const v = new THREE.Vector3();
  for (let i = 0; i < count; i++) {
    v.fromBufferAttribute(posA, i).normalize();
    const key = v.x.toFixed(3) + ',' + v.y.toFixed(3) + ',' + v.z.toFixed(3);
    let ui = map.get(key);
    if (ui === undefined) { ui = uDirs.length; map.set(key, ui); uDirs.push({ x: v.x, y: v.y, z: v.z }); }
    dirIdx[i] = ui;
  }

  const TAU = Math.PI * 2;
  const CENTERS = [];
  for (let k = 0; k < 26; k++) {
    CENTERS.push({
      c: new THREE.Vector3().randomDirection(),
      phase: Math.random() * TAU,
      speed: 1.0 + Math.random() * 1.6,
      amp:   0.36 + Math.random() * 0.30
    });
  }

  const meta = uDirs.map(d => {
    const dv = new THREE.Vector3(d.x, d.y, d.z);
    let bestW = 0, bestK = 0;
    for (let k = 0; k < CENTERS.length; k++) {
      const w = Math.max(0, dv.dot(CENTERS[k].c));
      if (w > bestW) { bestW = w; bestK = k; }
    }
    const spike = Math.pow(bestW, 16);
    return {
      dx: d.x, dy: d.y, dz: d.z,
      len: 0.74 + spike * 1.48 + Math.random() * 0.08,
      center: CENTERS[bestK],
      spike,
      wob: Math.random() * TAU,
      tint: Math.random()
    };
  });

  const colA = new THREE.BufferAttribute(new Float32Array(count * 3), 3);
  geo.setAttribute('color', colA);

  const mat = new THREE.MeshStandardMaterial({
    flatShading: true, vertexColors: true, roughness: 0.45, metalness: 0.15
  });
  const mesh = new THREE.Mesh(geo, mat);
  mesh.frustumCulled = false;

  const bias = new THREE.Vector3(0.35, 0.55, 0.25).normalize();
  const navy = new THREE.Color('#26385f');
  const mid  = new THREE.Color('#3d5580');
  const red  = new THREE.Color('#ff3b2f');
  const tmpC = new THREE.Color();

  function update(t) {
    const pulse = 1 + 0.05 * Math.sin(t * 2.4) + 0.022 * Math.sin(t * 4.6 + 1);
    for (let i = 0; i < count; i++) {
      const m = meta[dirIdx[i]];
      const breathe = 0.5 + 0.5 * Math.sin(t * m.center.speed + m.center.phase);
      let r = m.len * (0.7 + m.center.amp * breathe * (0.45 + 0.55 * m.spike));
      r += 0.05 * Math.sin(t * 3.4 + m.wob);
      r *= pulse;

      posA.setXYZ(i, m.dx * r, m.dy * r, m.dz * r);

      const tip = Math.min(1, Math.max(0, (r - 0.85) / 1.35));
      const biasV = (m.dx * bias.x + m.dy * bias.y + m.dz * bias.z) * 0.5 + 0.5;
      let k = tip * 0.85 + (biasV - 0.5) * 0.95 + m.tint * 0.14 - 0.18;
      k = Math.min(1, Math.max(0, k));
      k = k * k * (3 - 2 * k);
      if (k < 0.5) tmpC.lerpColors(navy, mid, k * 2);
      else tmpC.lerpColors(mid, red, (k - 0.5) * 2);
      const shade = 0.85 + 0.15 * tip;
      colA.setXYZ(i, tmpC.r * shade, tmpC.g * shade, tmpC.b * shade);
    }
    posA.needsUpdate = true;
    colA.needsUpdate = true;
  }
  return { mesh, update };
}
const blob = makeBlob();
stage.add(blob.mesh);

/* ============================================================
 *  Knowledge network: nodes + edges + labels, orbiting
 * ============================================================ */
const netGroup = new THREE.Group();
stage.add(netGroup);

const nodeGeo = new THREE.SphereGeometry(1, 14, 14);
const hitGeo  = new THREE.SphereGeometry(1, 8, 8);
const hitMat  = new THREE.MeshBasicMaterial({ transparent: true, opacity: 0, depthWrite: false });

function makeLabel(text, hub) {
  const fs = hub ? 30 : 24, pad = 10;
  const c = document.createElement('canvas');
  let ctx = c.getContext('2d');
  const font = (hub ? '500 ' : '400 ') + fs + 'px Inter, "Segoe UI", sans-serif';
  ctx.font = font;
  const w = Math.ceil(ctx.measureText(text).width) + pad * 2;
  const h = Math.ceil(fs * 1.5);
  c.width = w; c.height = h;
  ctx = c.getContext('2d');
  ctx.font = font;
  ctx.textBaseline = 'middle';
  ctx.fillStyle = hub ? 'rgba(214,226,241,0.96)' : 'rgba(166,182,204,0.92)';
  ctx.fillText(text, pad, h / 2 + 1);
  const tex = new THREE.CanvasTexture(c);
  tex.colorSpace = THREE.SRGBColorSpace;
  tex.anisotropy = 4;
  const spr = new THREE.Sprite(new THREE.SpriteMaterial({ map: tex, transparent: true, opacity: 0.82, depthWrite: false }));
  const s = 0.00165;
  spr.scale.set(w * s, h * s, 1);
  spr.center.set(0, 0.55);
  return spr;
}

/* fixed-seed shuffle so hub nodes spread over the sphere */
function mulberry32(a) {
  return function () {
    a |= 0; a = a + 0x6D2B79F5 | 0;
    let t = Math.imul(a ^ a >>> 15, 1 | a);
    t = t + Math.imul(t ^ t >>> 7, 61 | t) ^ t;
    return ((t ^ t >>> 14) >>> 0) / 4294967296;
  };
}
const order = NODES.map((_, i) => i);
const rnd = mulberry32(20260830);
for (let i = order.length - 1; i > 0; i--) {
  const j = Math.floor(rnd() * (i + 1));
  [order[i], order[j]] = [order[j], order[i]];
}

const nodeVisuals = [], labels = [], hitMeshes = [];
const golden = Math.PI * (3 - Math.sqrt(5));

order.forEach((ni, slot) => {
  const d = NODES[ni];
  const y = 1 - (slot / (N - 1)) * 2;
  const r = Math.sqrt(Math.max(0, 1 - y * y));
  const th = golden * slot;
  const dir = new THREE.Vector3(Math.cos(th) * r, y + (rnd() - 0.5) * 0.14, Math.sin(th) * r).normalize();
  const p = dir.multiplyScalar(2.4 + rnd() * 0.65);

  const isHub = !!d.hub;
  const size = isHub ? 0.05 : 0.032;
  const m = new THREE.Mesh(nodeGeo, new THREE.MeshBasicMaterial({
    color: isHub ? '#cfdcee' : '#93a7c4', transparent: true, opacity: 0.95
  }));
  m.scale.setScalar(size);
  m.position.copy(p);
  m.userData = { i: ni, base: p.clone(), phase: rnd() * 6.28, size: size, off: p.clone().normalize().multiplyScalar(0.085).add(new THREE.Vector3(0, 0.045, 0)) };
  netGroup.add(m);
  nodeVisuals[ni] = m;

  const hit = new THREE.Mesh(hitGeo, hitMat);
  hit.scale.setScalar(isHub ? 0.17 : 0.13);
  hit.userData.i = ni;
  netGroup.add(hit);
  hitMeshes[ni] = hit;

  const label = makeLabel(d.name, isHub);
  label.position.copy(p).add(m.userData.off);
  label.userData.baseScale = label.scale.clone();
  netGroup.add(label);
  labels[ni] = label;
});

/* ---------- edges: 2 nearest neighbors + a few remote ---------- */
const edgeSet = new Set(), edges = [];
function addEdge(a, b) {
  if (a === b) return;
  const key = Math.min(a, b) + '-' + Math.max(a, b);
  if (edgeSet.has(key)) return;
  edgeSet.add(key);
  edges.push([a, b]);
}
for (let i = 0; i < N; i++) {
  const dists = [];
  for (let j = 0; j < N; j++) if (j !== i) {
    dists.push([nodeVisuals[i].position.distanceTo(nodeVisuals[j].position), j]);
  }
  dists.sort((x, y) => x[0] - y[0]);
  addEdge(i, dists[0][1]);
  addEdge(i, dists[1][1]);
}
[1, 5, 10].forEach(i => addEdge(i, (i + 7) % N));

const edgeGeo = new THREE.BufferGeometry();
edgeGeo.setAttribute('position', new THREE.BufferAttribute(new Float32Array(edges.length * 6), 3));
const edgeLines = new THREE.LineSegments(edgeGeo, new THREE.LineBasicMaterial({
  color: '#7f95b5', transparent: true, opacity: 0.16, depthWrite: false
}));
edgeLines.frustumCulled = false;
netGroup.add(edgeLines);

/* spokes: hubs tethered toward the organism */
const hubIdx = NODES.map((d, i) => d.hub ? i : -1).filter(i => i >= 0);
const spokeGeo = new THREE.BufferGeometry();
spokeGeo.setAttribute('position', new THREE.BufferAttribute(new Float32Array(hubIdx.length * 6), 3));
const spokeLines = new THREE.LineSegments(spokeGeo, new THREE.LineBasicMaterial({
  color: '#5f7391', transparent: true, opacity: 0.09, depthWrite: false
}));
spokeLines.frustumCulled = false;
netGroup.add(spokeLines);

/* ---------- selection: pulse ring + highlight edges ---------- */
function makeRing() {
  const c = document.createElement('canvas'); c.width = c.height = 128;
  const ctx = c.getContext('2d');
  ctx.strokeStyle = 'rgba(255,96,80,0.95)'; ctx.lineWidth = 5;
  ctx.beginPath(); ctx.arc(64, 64, 52, 0, Math.PI * 2); ctx.stroke();
  ctx.strokeStyle = 'rgba(255,96,80,0.3)'; ctx.lineWidth = 2;
  ctx.beginPath(); ctx.arc(64, 64, 59, 0, Math.PI * 2); ctx.stroke();
  const tex = new THREE.CanvasTexture(c);
  const spr = new THREE.Sprite(new THREE.SpriteMaterial({
    map: tex, transparent: true, blending: THREE.AdditiveBlending, depthWrite: false
  }));
  spr.visible = false;
  return spr;
}
const ring = makeRing();
netGroup.add(ring);

let hlLines = null;
function buildHighlight(i) {
  if (hlLines) { netGroup.remove(hlLines); hlLines.geometry.dispose(); hlLines.material.dispose(); hlLines = null; }
  if (i < 0) return;
  const mine = edges.filter(e => e[0] === i || e[1] === i);
  const g = new THREE.BufferGeometry();
  g.setAttribute('position', new THREE.BufferAttribute(new Float32Array(mine.length * 6), 3));
  hlLines = new THREE.LineSegments(g, new THREE.LineBasicMaterial({
    color: '#ff6a58', transparent: true, opacity: 0.5, depthWrite: false
  }));
  hlLines.frustumCulled = false;
  hlLines.userData.mine = mine;
  netGroup.add(hlLines);
}

/* ============================================================
 *  Panel wiring (right side)
 * ============================================================ */
const panelWrap = document.getElementById('panel-wrap');
const inner   = document.getElementById('panel-inner');
const kEl     = document.getElementById('panel-kicker');
const tEl     = document.getElementById('panel-title');
const subEl   = document.getElementById('panel-sub');
const dEl     = document.getElementById('panel-desc');
const hintText= document.getElementById('hint-text');

const DEFAULT = {
  kicker: 'OPEN SOURCE SYSTEMS BIOLOGY',
  title: 'GCModeller',
  sub: 'genomics CAD (Computer Assistant Design) Modeller System',
  desc: 'From genome annotation to virtual-cell simulation and pan-omics analysis — design, run and iterate complete computational biology workflows, scripted freely in <strong>R#</strong>.',
  hint: 'Click a node in the knowledge network to explore the concepts behind GCModeller'
};

let swapT = null;
function swapPanel(kicker, title, subHTML, descHTML) {
  inner.classList.add('swap');
  clearTimeout(swapT);
  swapT = setTimeout(() => {
    kEl.textContent = kicker;
    tEl.textContent = title;
    subEl.innerHTML = subHTML;
    dEl.innerHTML = descHTML;
    inner.classList.remove('swap');
  }, 240);
}
function setHint(text) {
  hintText.textContent = text;
  hint.classList.remove('hidden');
}

const pad2 = n => String(n).padStart(2, '0');
const baseScale  = i => nodeVisuals[i].userData.size;
const baseColor  = i => NODES[i].hub ? '#cfdcee' : '#93a7c4';

let selected = -1, hovered = -1;

function select(i) {
  selected = i;
  if (i >= 0) {
    const d = NODES[i];
    swapPanel('KNOWLEDGE NETWORK · NODE ' + pad2(i + 1) + ' / ' + N, d.name, '<span class="ndot">●</span> ' + d.tag.toUpperCase(), d.desc);
    setHint('Press ESC or click empty space to return to the overview');
    nodeVisuals[i].material.color.set('#ff5347');
    nodeVisuals[i].scale.setScalar(baseScale(i) * 1.9);
    labels[i].material.opacity = 1;
    labels[i].scale.copy(labels[i].userData.baseScale).multiplyScalar(1.15);
    ring.visible = true;
    buildHighlight(i);
  } else {
    swapPanel(DEFAULT.kicker, DEFAULT.title, DEFAULT.sub, DEFAULT.desc);
    setHint(DEFAULT.hint);
    ring.visible = false;
    buildHighlight(-1);
    nodeVisuals.forEach((m, idx) => {
      m.material.color.set(baseColor(idx));
      m.scale.setScalar(baseScale(idx));
      labels[idx].material.opacity = 0.82;
      labels[idx].scale.copy(labels[idx].userData.baseScale);
    });
  }
}

/* ---------- picking ---------- */
const ray = new THREE.Raycaster(), ndc = new THREE.Vector2();
function pickAt(cx, cy) {
  ndc.set((cx / window.innerWidth) * 2 - 1, -(cy / window.innerHeight) * 2 + 1);
  ray.setFromCamera(ndc, camera);
  const hits = ray.intersectObjects(hitMeshes, false);
  return hits.length ? hits[0].object.userData.i : -1;
}

window.addEventListener('pointermove', e => {
  mx = (e.clientX / window.innerWidth) * 2 - 1;
  my = -((e.clientY / window.innerHeight) * 2 - 1);
  const h = pickAt(e.clientX, e.clientY);
  setHover(h);
});

function setHover(i) {
  if (i === hovered) return;
  if (hovered >= 0 && hovered !== selected) {
    const m = nodeVisuals[hovered];
    m.scale.setScalar(baseScale(hovered));
    m.material.color.set(baseColor(hovered));
    labels[hovered].material.opacity = 0.82;
  }
  hovered = i;
  if (i >= 0 && i !== selected) {
    const m = nodeVisuals[i];
    m.scale.setScalar(baseScale(i) * 1.55);
    m.material.color.set('#e9f1fb');
    labels[i].material.opacity = 1;
  }
  canvas.style.cursor = i >= 0 ? 'pointer' : 'default';
}

canvas.addEventListener('click', e => {
  select(pickAt(e.clientX, e.clientY));
});
window.addEventListener('keydown', e => { if (e.key === 'Escape') select(-1); });

/* ---------- mouse tilt + light ---------- */
let mx = -0.8, my = 0.78;      // 初始光在左上（呼应旧版官网角落辉光）
let sx = mx, sy = my, lx = mx, ly = my;

const worldAt = (nx, ny, z) => {
  const dist = camera.position.z - z;
  const halfH = Math.tan(THREE.MathUtils.degToRad(camera.fov / 2)) * dist;
  const halfW = halfH * camera.aspect;
  return [nx * halfW, ny * halfH];
};

/* ---------- layout ---------- */
function layout() {
  const w = window.innerWidth, h = window.innerHeight;
  const aspect = w / h;
  camera.aspect = aspect;
  camera.updateProjectionMatrix();
  renderer.setSize(w, h);
  renderer.setPixelRatio(Math.min(window.devicePixelRatio, 2));
  if (aspect > 1.15) stage.position.set(-1.62, -0.05, 0);
  else stage.position.set(0, 0.85, 0);
}
layout();
window.addEventListener('resize', layout);

/* ---------- debug hooks ---------- */
window.__select = i => select(i);
window.__pickAt = (x, y) => pickAt(x, y);
window.__nodeScreen = i => {
  const v = nodeVisuals[i].position.clone().applyMatrix4(netGroup.matrixWorld).project(camera);
  return [(v.x * 0.5 + 0.5) * window.innerWidth, (-v.y * 0.5 + 0.5) * window.innerHeight];
};
window.__errors = [];
window.addEventListener('error', e => window.__errors.push(String(e.message || e)));

/* ============================================================
 *  Main loop
 * ============================================================ */
const clock = new THREE.Clock();
let t = 0, readyShown = false;

function tick() {
  requestAnimationFrame(tick);
  const dt = Math.min(clock.getDelta(), 0.05);
  t += dt;

  const kTilt  = 1 - Math.exp(-dt * 3.5);
  const kLight = 1 - Math.exp(-dt * 9.0);
  sx += (mx - sx) * kTilt;
  sy += (my - sy) * kTilt;
  lx += (mx - lx) * kLight;
  ly += (my - ly) * kLight;

  stage.rotation.y = sx * 0.22;
  stage.rotation.x = -sy * 0.16;
  stars.rotation.y = t * 0.006 + sx * 0.06;
  stars.rotation.x = -sy * 0.045;

  const [gx, gy] = worldAt(lx, ly, 3.3);
  mouseLight.position.set(gx, gy, 3.3);
  glow.position.copy(mouseLight.position);

  blob.update(t);
  blob.mesh.rotation.y = t * 0.09;
  blob.mesh.rotation.x = Math.sin(t * 0.13) * 0.1;
  blob.mesh.position.y = Math.sin(t * 0.85) * 0.05;

  netGroup.rotation.y = t * 0.3;
  netGroup.rotation.x = Math.sin(t * 0.32) * 0.14;
  netGroup.rotation.z = Math.sin(t * 0.24 + 1.7) * 0.09;

  for (let i = 0; i < N; i++) {
    const m = nodeVisuals[i], u = m.userData;
    m.position.set(
      u.base.x,
      u.base.y + Math.sin(t * 0.8 + u.phase) * 0.06,
      u.base.z + Math.sin(t * 0.6 + u.phase * 1.3) * 0.02
    );
    hitMeshes[i].position.copy(m.position);
    labels[i].position.copy(m.position).add(u.off);
  }

  const ep = edgeGeo.attributes.position;
  for (let k = 0; k < edges.length; k++) {
    const A = nodeVisuals[edges[k][0]].position;
    const B = nodeVisuals[edges[k][1]].position;
    ep.setXYZ(k * 2, A.x, A.y, A.z);
    ep.setXYZ(k * 2 + 1, B.x, B.y, B.z);
  }
  ep.needsUpdate = true;

  const sp = spokeGeo.attributes.position;
  hubIdx.forEach((hi, k) => {
    const A = nodeVisuals[hi].position;
    sp.setXYZ(k * 2, A.x, A.y, A.z);
    sp.setXYZ(k * 2 + 1, 0, 0, 0);
  });
  sp.needsUpdate = true;

  if (hlLines && selected >= 0) {
    const hp = hlLines.geometry.attributes.position;
    const mine = hlLines.userData.mine;
    for (let k = 0; k < mine.length; k++) {
      const A = nodeVisuals[mine[k][0]].position;
      const B = nodeVisuals[mine[k][1]].position;
      hp.setXYZ(k * 2, A.x, A.y, A.z);
      hp.setXYZ(k * 2 + 1, B.x, B.y, B.z);
    }
    hp.needsUpdate = true;
  }

  if (ring.visible && selected >= 0) {
    ring.position.copy(nodeVisuals[selected].position);
    const pr = (t * 0.85) % 1;
    const s = 0.16 + pr * 0.5;
    ring.scale.set(s, s, 1);
    ring.material.opacity = 0.75 * (1 - pr);
  }

  panelWrap.style.transform = 'perspective(1400px) rotateY(' + (sx * 6).toFixed(3) + 'deg) rotateX(' + (-sy * 4.5).toFixed(3) + 'deg)';

  renderer.render(scene, camera);

  if (!readyShown) {
    readyShown = true;
    window.__sceneReady = true;
    document.body.classList.add('ready');
  }
}
tick();
