// Draw red canvas

// return created canvas

export function create_canvas(height, width) {
    let canvas = document.getElementById("my_canvas");
    let gl = canvas.getContext("webgl");
    if (height === undefined) {
        height = canvas.clientHeight;
    }
    if (width === undefined) {
        width = canvas.clientWidth;
    }
    gl.canvas.width = width;
    gl.canvas.height = height;
    gl.viewport(0, 0, width, height);
    gl.clearColor(1.0, 0.0, 0.0, 1.0);
    gl.clear(gl.COLOR_BUFFER_BIT);
} 

export function recolor_canvas(red, green, blue) {
    let canvas = document.getElementById("my_canvas");
    let gl = canvas.getContext("webgl")
    gl.clearColor(red, green, blue, 1.0);
    gl.clear(gl.COLOR_BUFFER_BIT);
}