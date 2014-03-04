//注册日期控件
$('input.calendar:not([data-calendar-group])').die('click').live('click', function () {
    WdatePicker({
        el: $(this).attr('id')
    });
});

$('.WdayTable td').die('click').live('click', function () {
    $(':focus').blur();
});
