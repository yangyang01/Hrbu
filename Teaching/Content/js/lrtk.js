// JavaScript Document
$(document).ready(function (e) {
    window.onload = function () {
        speed = -1;
        move = getId('banner');
        getId('wrap2').innerHTML = getId('wrap1').innerHTML;
        var time = setInterval(automove, 40);
        getId('main').onmouseover = function () {
            clearInterval(time);
        }
        getId('main').onmouseout = function () {
            time = setInterval(automove, 60);
        }
        getId('left').onclick = function () {
            speed = -1;
        }
        getId('right').onclick = function () {
            speed = 1;
        }
    }
    function getId(id) {
        return document.getElementById(id);
    }
    function automove() {
        if (parseInt(move.style.left) <= -getId('wrap1').offsetWidth) {
            move.style.left = 0 + 'px';
        }
        if (move.offsetLeft > 0) {
            move.style.left = -getId('wrap1').offsetWidth + 'px';
        }
        move.style.left = move.offsetLeft + speed + 'px';
    }
});

$(document).ready(function () {
    $('.og_prev,.og_next').hover(function () {
        $(this).fadeTo('fast', 1);
    }, function () {
        $(this).fadeTo('fast', 0.7);
    })

})

