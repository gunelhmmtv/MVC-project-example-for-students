$(document).ready(function () {
    $('#add-btn').click(AddNewOrder)
    LoadOrder();

})

function AddNewOrder() {
    var orderNumber = $('#orderNumber').val();
    var orderDate = $('#orderDate').val();
    var totalPrice = $('#totalPrice').val();
    var id = $('#order-id').val();

    const order = {
        orderNumber: orderNumber,
        orderDate: orderDate,
        totalPrice: totalPrice,
        id:id
    };




    $.ajax({
        async: true,
        type: "POST",
        url: "/Order/AddOrder/",
        dataType: "JSON",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(order),
        success: function (response) {
            console.log(response);
            Swal.fire({
                position: "center",
                icon: "success",
                title: response.message,
                showConfirmButton: false,
                timer: 1500
            });
            //window.location.href = "book/book";
        },
    });


}



