import { create_canvas } from './amnesia.js';
import { AmnesiaInit, OnKeyDown, OnKeyUp} from './import.js'


Blazor.start().then(function () {
    AmnesiaInit(); 
    create_canvas();

    document.onkeydown = function (event) {
        OnKeyDown();
    }

    document.onkeyup = function (event) {
        OnKeyUp();
    }
});


