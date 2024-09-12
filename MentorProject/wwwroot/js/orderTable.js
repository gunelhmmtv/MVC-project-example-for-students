$(document).ready(function () {
    LoadOrder();
});

function LoadOrder() {
    $("#order-datatable").DataTable({
        autoWidth: false,
        pageLength: 5,
        lengthMenu: [[5, 10, 15], [5, 10, 15]],
        ajax: {
            url: "/Order/AddOrder",
            dataSrc: ""
        },
        columns: [
            { data: 'id' },
            { data: 'orderNumber' },
            { data: 'orderDate' },
            { data: 'totalPrice' },


        ]
    });



}



