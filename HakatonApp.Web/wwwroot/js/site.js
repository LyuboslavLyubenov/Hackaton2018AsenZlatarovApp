$(function () {
    $('#carousel').slick();
    $('#second_menu button').click(function (event) {
        event.stopPropagation();
        $('.second-content').css('display', 'none');
        let id = $(this).attr('href');
        $('#' + id).css('display', 'flex');
    });
});
