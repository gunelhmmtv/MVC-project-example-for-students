$(document).ready(function () {
    LoadBook();
});

function LoadBook() {
    $("#book-datatable").DataTable({
        autoWidth: false,
        pageLength: 5,
        lengthMenu: [[5, 10, 15], [5, 10, 15]],
        ajax: {
            url: "/Book/Book/AddBook", 
            dataSrc: ""
        },
        columns: [
            { data: 'id' },
            { data: 'bookName' },
            { data: 'price' },
            { data: 'inStock' },
           
            
        ]
    });



}



