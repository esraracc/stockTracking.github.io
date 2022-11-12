(function ($) {
    "use strict";

    $(document).ready(function () {
        $('#data-table-basic').DataTable({
            responsive: true,
            language: {
                url: 'https://cdn.datatables.net/plug-ins/1.13.1/i18n/tr.json'
            }
        });
    });

})(jQuery);