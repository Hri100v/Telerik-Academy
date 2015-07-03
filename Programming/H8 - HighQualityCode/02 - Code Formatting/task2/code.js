var off = 0;
var txt = "";
var pX = 0;
var pY = 0;
var navigator;
var document;
var window;
var event;
var mouseMove;
var Event;
var theLayer;


var b = navigator.appName;
var addScroll = false;
if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
    addScroll = true;
}

document.onmousemove = mouseMove;
if (b === "Netscape") {
    document.captureEvents(Event.MOUSEMOVE);
}

function PopTip() {
    'use strict';
    if (b === "Netscape") {
        theLayer = document.layers.ToolTip;
        if ((pX + 120) > window.innerWidth) {
            pX = window.innerWidth - 150;
        }
        theLayer.left = pX + 10;
        theLayer.top = pY + 15;
        theLayer.visibility = 'show';
    } else {
        theLayer = document.all.ToolTip;
        if (theLayer) {
            pX = event.x - 5;
            pY = event.y;
            if (addScroll) {
                pX = pX + document.body.scrollLeft;
                pY = pY + document.body.scrollTop;
            }

            if ((pX + 120) > document.body.clientWidth) {
                pX = pX - 150;
            }

            theLayer.style.pixelLeft = pX + 10;
            theLayer.style.pixelTop = pY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
}

function mouseMove(evn) {
    'use strict';
    if (b === "Netscape") {
        pX = evn.pageX - 5;
        pY = evn.pageY;
    } else {
        pX = evn.x - 5;
        pY = evn.y;
    }

    if (b === "Netscape") {
        if (document.layers.ToolTip.visibility === 'show') {
            return new PopTip();
        }
    } else {
        if (document.all.ToolTip.style.visibility === 'visible') {
            return new PopTip();
        }
    }
}

function HideTip() {
    'use strict';
    if (b === "Netscape") {
        document.layers.ToolTip.visibility = 'hide';
    } else {
        document.all.ToolTip.style.visibility = 'hidden';
    }
}

function HideMenu1() {
    'use strict';
    if (b === "Netscape") {
        document.layers.menu1.visibility = 'hide';
    } else { document.all.menu1.style.visibility = 'hidden'; }
}

function ShowMenu1() {
    'use strict';
    if (b === "Netscape") {
        theLayer = document.layers.menu1;
        theLayer.visibility = 'show';
    } else {
        theLayer = document.all.menu1;
        theLayer.style.visibility = 'visible';
    }
}//

function HideMenu2() {
    'use strict';
    if (b === "Netscape") {
        document.layers.menu2.visibility = 'hide';
    } else {
        document.all.menu2.style.visibility = 'hidden';
    }
}

function ShowMenu2() {
    'use strict';
    if (b === "Netscape") {
        theLayer = document.layers.menu2;
        theLayer.visibility = 'show';
    } else {
        theLayer = document.all.menu2;
        theLayer.style.visibility = 'visible';
    }
}