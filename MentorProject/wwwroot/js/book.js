$(document).ready(function () {
    $('#add-btn').click(AddNewBook)
    LoadBook();

})

function AddNewBook() {
    var bookName = $('#book-name').val();
    var price = $('#price').val();
    var inStock = $('#inStock').val();
    var id = $('#book-id').val();

    const book = {
        id: id,
        bookName: bookName,
        price: price,
        inStock: inStock
    };




    $.ajax({
        async: true,
        type: "POST",
        url: "/Book/AddBook",
        dataType: "JSON",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(book),
        success: function (response) {
            console.log(response);
            Swal.fire({
                position: "center",
                icon: "success",
                title: response.message,
                showConfirmButton: false,
                timer: 1500
            });
            window.location.href = "book/book";
        },
    });

   
}

    

