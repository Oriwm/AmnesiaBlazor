import { recolor_canvas } from './amnesia.js';

window.Alert = (message) => {
    alert(`${message}!`);
};

window.js_recolor_canvas = (red, green, blue) => {
    recolor_canvas(red, blue, green);
};