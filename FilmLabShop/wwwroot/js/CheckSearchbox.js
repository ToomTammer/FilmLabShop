$(function () {
        $('#f_search input').keydown(function (e) {

            var searchTerm = $("#ipt_search").val();

            if (searchTerm == "" && event.keyCode === 13) {
                e.preventDefault();
                return false;
            }
        });


        $('#f_search input').each(function () {
            if ($(this).is(':empty')) {
                $('#f_search #btnsearch').preventDefault();
            }
        });


})
