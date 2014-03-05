function CheckPasswordComplexity(password) {
    var mode = 0;
    if (password.length == 0) {
        return -1;
    }
    if (password.length < 6) {
        return mode;
    }
    if (password.length > 15) {
        return 4;
    }
    if (/\d/.test(password)) mode++; //数字
    if (/[a-z]|[A-Z]/.test(password)) mode++; //字母
    if (/\W/.test(password)) mode++; //特殊字符

    return mode;
}

function openDialog(url, width, height) {
    var _w = 1160, _h = 630;
    _w = width || _w;
    _h = height || _h;

    var iTop = 20; //获得窗口的垂直位置;
    var iLeft = (window.screen.availWidth - 10 - _w) / 2; //获得窗口的水平位置;
    window.open(url, "_blank", "width=" + _w + ",height=" + _h + ",top=" + iTop + ",left=" + iLeft + ",resizable=1,scrollbars=1,fullscreen=0");
}

function showModuleDialog(url, width, height) {
    var _w = 900, _h = 650;
    _w = width || _w;
    _h = height || _h;
    window.showModalDialog(url, window, "dialogWidth=" + _w + "px;dialogHeight=" + _h + "px");
}
function GetParentWindow() {
    var opener = window.opener;
    if (!opener) {
        //for IE window.opener=undefined
        opener = window.dialogArguments;
    }
    if (!opener) {
        opener = window.parent;
    }

    return opener;
}
//关闭本页面并刷新父页面
function RefreshParentAndCloseSelf() {
    var opener = GetParentWindow();
    if (typeof opener.location.href == 'string') {
        opener.location.href = GetParentHref();
    }
    window.open('', '_self', '');
    window.close();
}

function RefreshParentAndSelf(href) {
    var parent = GetParentWindow();
    if (parent != null) {
        parent.location.href = GetParentHref();
    }
    window.location.href = href;
}

function RefreshParent() {
    var opener = GetParentWindow();

    opener.location.href = GetParentHref();

    window.open('', '_self', '');
}

function RefreshSelf() {
    window.location.href = window.location.href + "?" + Math.random();
}