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

function GetParentHref() {
    var parent = GetParentWindow();
    if (parent != null) {
        return parent.location.protocol + '//' + parent.location.host + parent.location.pathname;
    }
}

function GetLocationHref(locat) {
    return locat.protocol + '//' + locat.host + locat.pathname;
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

function CloseParentWhenDetailAndCloseSelf() {
    var parent = GetParentWindow();

    var pendingList = parent;

    if ($("#hfFromPage").val() == "Detail") {
        pendingList = parent.opener;
        $(parent.document.getElementById("hfIsFromReject")).val(true);
    }

    window.open('', '_self', '');
    window.close();

    pendingList.location.href = GetLocationHref(pendingList.location);
}

function CloseSelf() {
    window.open('', '_self', '');
    window.close();
}
function focusNumberInput(element) {
    var keycode = event.keyCode;

    if (keycode > 57 || keycode < 47) {
        if (keycode == 45)
            return true;
        return false;
    }
}
//检查符合手机和电话格式
function CheckPhoneTel(ele) {
    var tel = $(ele).val();
    var regex_mobile = /^1\d{10}$/,
        regex_tel = new RegExp("^(0[0-9]{2,3}\-)([2-9][0-9]{6,7})$");
    if (tel == "") {
        args.IsValid = false;
    } else {
        if (regex_mobile.test(tel) || regex_tel.test(tel)) {
            return true;
        }
        return false;
    }
}
function checkTextAreaMaxLength(textBox, e, length) {

    var mLen = textBox["MaxLength"];
    if (null == mLen)
        mLen = length;

    var maxLength = parseInt(mLen);
    if (!checkSpecialKeys(e)) {
        if (textBox.value.length > maxLength - 1) {
            if (window.event)//IE
            {
                e.returnValue = false;
                return false;
            }
            else//Firefox
                e.preventDefault();
        }
    }
}
var wrapperError = function (msg) {
    if (msg != "") {
        return "<span>" + msg + "</br></span>";
    }
    return "";
}

//页面必填选项的检查
function ClientValidate(button, outCheck, errorHandler, outContainer) {
    var container = $(button).parents('body');

    if (outContainer && outContainer.length) {
        container = outContainer;
    }

    var errorMsg = "";
    container.find('span[data-required-info]').each(function () {
        if ($(this).is(':visible')) {
            var input = $(this).parents('.parameter_name').siblings('.parameter_input:visible'),
            inputEle = input.find('input');
            if (inputEle.length == 0) inputEle = input.find('select');
            if (inputEle.length == 0) inputEle = input.find('textarea');
            if (inputEle.length == 0) inputEle = input.find('span');

            if (inputEle.length > 0) {
                if (inputEle.attr('type') == 'radio') {
                    var groupName = inputEle.attr('name');
                    if ($("input[type=radio][name='" + groupName + "']:checked").length == 0) {
                        errorMsg += "<span>" + $(this).attr('data-required-info') + "</br></span>";
                    }
                } else if (inputEle.get(0).tagName == "SPAN") {
                    if ($.trim(inputEle.text()) == "") {
                        errorMsg += "<span>" + $(this).attr('data-required-info') + "</br></span>";
                    }
                }
                else if (inputEle.attr('id') == "txtEmergencyTel") {
                    if ($.trim(inputEle.val()) == "") {
                        errorMsg += "<span>" + $(this).attr('data-required-info') + "</br></span>";
                    }
                    //else if (!CheckPhoneTel(inputEle)) {
                    //    errorMsg += "<span>紧急联系电话格式不正确!</br></span>";
                    //}
                } else if ($.trim(inputEle.val()) == "" || inputEle.val() == null) {
                    errorMsg += "<span>" + $(this).attr('data-required-info') + "</br></span>";
                }
            }
        }
    });

    //添加外部补充的必填验证
    if (outCheck && typeof outCheck == "function") {
        errorMsg += outCheck();
    }

    if (errorHandler && typeof errorHandler === "function") {
        errorHandler(errorMsg);
    } else {
        showPageError(container, errorMsg);
    }

    return errorMsg == "";
}

function showPageError(container, errorMsg) {
    var closeButton = "<a class='block_button fr closeError'>关闭错误信息</a>",
        content = container.find('.margin_1140_center'),
        errorContainer = container.find(".errorField"),
        overBudgetContainer = container.find('#DivOverBudget');
    if (errorMsg != "") {
        errorContainer.html('').append(closeButton).append(errorMsg).show();
        content.css({ top: errorContainer.height() + 'px' });

        if (overBudgetContainer.is(":visible")) {
            overBudgetContainer.css({ top: errorContainer.height() + 30 + 'px' });
            content.css({ top: errorContainer.height() + overBudgetContainer.height() + 'px' });
        }

        $(document).scrollTop(0);

        errorContainer.find(".closeError").bind('click', function () {
            errorContainer.hide();
            overBudgetContainer.css({ top: '0px' });
            content.css({ top: '0px' });

            if (overBudgetContainer.is(":visible")) {
                overBudgetContainer.css({ top: '10px' });
                content.css({ top: +(overBudgetContainer.height()) + 'px' });
            }
        });
    } else {
        errorContainer.hide();
        overBudgetContainer.css({ top: '0px' });
        content.css({ top: '0px' });

        if (overBudgetContainer.is(":visible")) {
            overBudgetContainer.css({ top: '10px' });
            content.css({ top: +(overBudgetContainer.height()) + 'px' });
        }
    }
}