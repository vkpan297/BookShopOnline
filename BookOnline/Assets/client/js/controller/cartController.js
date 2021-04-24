﻿var cart={
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('#btnContinue').off('click').on('click', function () {
            window.location.href="/";
        });

        $('#btnPayment').off('click').on('click', function () {
            window.location.href = "/thanh-toan";
        });

        $('#btnUpdate').off('click').on('click', function () {
            var listBook = $('.txtQuantity');
            var cartList = [];
            $.each(listBook, function (i, item) {
                cartList.push({
                    SoLuong: $(item).val(),
                    Sach: {
                        IDSach:$(item).data('id')
                    }
                });
            });

            $.ajax({
                url: '/Cart/Update',
                data: { cartModel: JSON.stringify(cartList) },
                datatType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href="/gio-hang"
                    }
                    
                }
            })
        });

        $('#btnDeletAll').off('click').on('click', function () {
            
            $.ajax({
                url: '/Cart/DeleteAll',               
                datatType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/gio-hang"
                    }

                }
            })
        });

        $('.btn-Delete').off('click').on('click', function (e) {
            e.preventDefault();
            $.ajax({
                data:{id:$(this).data('id')},
                url: '/Cart/Delete',
                datatType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/gio-hang"
                    }

                }
            })
        });
    }
}
cart.init();