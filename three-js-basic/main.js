import * as THREE from 'three';
import { OrbitControls } from 'three/addons/controls/OrbitControls.js';
import { Pane } from 'tweakpane';
const pane=new Pane();
const scene=new THREE.Scene();
const textureLoader=new THREE.TextureLoader();
const textureTest=textureLoader.load("./assets/bamboo-wood-semigloss-albedo.png");
console.log({textureTest});
textureTest.repeat.set(10,10);
textureTest.wrapS=THREE.RepeatWrapping;
textureTest.wrapT=THREE.RepeatWrapping;
let geometry=new THREE.BoxGeometry(1,1,1);
const geometryParams={
    x: 1,
    y: 1,
    z: 1
}
const cubeMaterial=new THREE.MeshLambertMaterial();
cubeMaterial.map=textureTest;
const cubeMesh=new THREE.Mesh(geometry, cubeMaterial);
const temoVector=new THREE.Vector3(0,0,0);
cubeMesh.position.copy(temoVector);
scene.add(cubeMesh);
const light=new THREE.AmbientLight(0xffffff, 0.2);
scene.add(light);
const pointLight = new THREE.PointLight( 0xffffff, 100);
pointLight.position.set( 5, 5, 2 );
scene.add( pointLight );

const sphereSize = 1;
const pointLightHelper = new THREE.PointLightHelper( pointLight, sphereSize );
scene.add( pointLightHelper );
const paneFolder = pane.addFolder({
    title: 'geometry',
    expanded: true,
});
const paneSet=(param)=>{
    return {
        min: 0,
        max: 10,
        step: 0.1,
        label: param
    }
}
const paneX=paneFolder.addBinding(geometryParams, "x", paneSet("x"))
const paneY=paneFolder.addBinding(geometryParams, "y", paneSet("y"))
const paneZ=paneFolder.addBinding(geometryParams, "z", paneSet("z"))
const paneChange=(ev)=>{
    // console.log(`change: ${ev.value}`);
    geometry=new THREE.BoxGeometry(geometryParams.x, geometryParams.y, geometryParams.z);
    cubeMesh.geometry=geometry;
}
paneX.on('change', paneChange);
paneY.on('change', paneChange);
paneZ.on('change', paneChange);


const axesHelper=new THREE.AxesHelper(3);
scene.add(axesHelper);
const camera=new THREE.PerspectiveCamera(
    35,
    window.innerWidth / window.innerHeight,
    0.5,
    200
);
/*
const aspectRatio=window.innerWidth / window.innerHeight;
const camera=new THREE.OrthographicCamera(
    -1 * aspectRatio,
    1 * aspectRatio,
    1,
    -1,
    0.1,
    200
)
*/
camera.position.set(6, 6, 6);
// console.log("mesh distanceTo camera" ,cubeMesh.position.distanceTo(camera.position));
// scene.add(camera);
const canvas=document.querySelector("canvas.threejs");
const renderer=new THREE.WebGLRenderer({
    canvas,
    antialias: true,
});
renderer.setSize(window.innerWidth, window.innerHeight);
console.log("devicePixelRatio", window.devicePixelRatio);
const minPixelRatio=Math.min(window.devicePixelRatio, 2);
renderer.setPixelRatio(minPixelRatio);
const control=new OrbitControls(camera, canvas);
control.enableDamping=true;
// control.autoRotate=true;
window.addEventListener("resize", ()=>{
    console.log("[resize]");
    camera.aspect=window.innerWidth / window.innerHeight;
    camera.updateProjectionMatrix();
    renderer.setSize(window.innerWidth, window.innerHeight);
});
const clock=new THREE.Clock();
let previousTime=0;

const renderloop=()=>{
    // console.log("[renderloop]");
    const currentTime=clock.getElapsedTime();
    const delta=currentTime-previousTime;
    previousTime=currentTime;
    control.update();
    renderer.render(scene, camera);
    window.requestAnimationFrame(renderloop);
}
renderloop()