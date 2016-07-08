function formDate(inData) {
    var date = new Date(inData);
    var month = date.getMonth() + 1;
    return (month.length > 1 ? month : "0" + month) + "/" + date.getDate() + "/" + date.getFullYear();
}


$(document).ready(function () {
    $('#trades').DataTable({
        columns: [
            { data: "TradeDate", render: function (data) { return formDate(data)} },
            { data: "SettleDate", render: function (data) {return formDate(data) }},
            { data: "Symbol" },
            { data: "Account" },
            { data: "Quantity" },
            { data: "Price", render: $.fn.dataTable.render.number(',', '.', 2, '$') },
            { data: "Principal" },
            { data: "Currency" }
        ]
    });

});

