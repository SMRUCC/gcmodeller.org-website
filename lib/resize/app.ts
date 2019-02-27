/// <reference path="../linq.d.ts" />

$ts(function () {
    let size = DOM.clientSize();
    let iframe = document.getElementsByTagName("iframe");

    // fix for padding
    size[0] = size[0] * 0.95;

    if (size[0] <= 500) {
        for (var i = 0; i < iframe.length; i++) {
            let frame = iframe.item(i);
            let w: number = parseInt((/\d+/ig).exec(frame.width)[0]);
            let h: number = parseInt((/\d+/ig).exec(frame.height)[0]);

            iframe.item(i).width = `${size[0]}px`;
            iframe.item(i).height = `${size[0] * h / w}px`;
        }
    }
});