/**
 *
 * You can write your JS code here, DO NOT touch the default style file
 * because it will make it harder for you to update.
 * 
 */
// Common functions
var common = {
    delete: function (info) {
        // Hiển thi confim xác nhận xóa
        $.confirm({
            title: info.Title,
            content: info.Content,
            useBootstrap: false,
            theme: 'material',
            type: 'red',
            boxWidth: '500px',
            buttons: {
                confirm: {
                    text: info.ConfirmButton,
                    keys: ['enter'],
                    btnClass: 'btn-red',
                    action: function () {

                        // Cập nhật trạng thái 
                        var dataModel =
                        {
                            Id: info.Id,
                            
                            __RequestVerificationToken: info.RequestVerificationToken
                        };

                        jQuery.ajax({
                            url: info.Url,
                            type: "POST",
                            data: dataModel,
                            dataType: "json",
                            cache: false,
                            success: function (result) {
                                console.log(result.errorCode);
                                if (result.errorCode == "0") {
                                    $.confirm({
                                        title: 'Thông báo',
                                        useBootstrap: false,
                                        type: 'blue',
                                        boxWidth: '500px',
                                        content: 'Xóa dữ liệu thành công',
                                        buttons: {
                                            confirm: {
                                                text: 'OK',
                                                btnClass: 'btn-blue',
                                                key: ['enter'],
                                                action: function () {
                                                    location.reload();
                                                }
                                            }
                                        }
                                    });
                                }
                                
                                else {
                                    $.alert({
                                        title: 'Thông báo lỗi',
                                        useBootstrap: false,
                                        type: 'red',
                                        boxWidth: '500px',
                                        content: result.errorMessage
                                    });
                                }
                            },
                            error: function (error) {
                                $.alert({
                                    title: info.errorTitle,
                                    content: info.errorContent,
                                    useBootstrap: false,
                                    type: 'red',
                                    boxWidth: '500px'
                                });
                            }
                        });
                    }
                },
                cancel: {
                    text: info.CancelButton,
                    keys: ['esc'],
                    action: function () {
                    }
                },
            }
        });
    },

    updateStatus: function (info) {
        // Hiển thị dialog confirm
        $.confirm({
            title: info.Title,
            content: info.Content,
            useBootstrap: false,
            theme: 'material',
            type: 'red',
            boxWidth: '500px',
            buttons: {
                confirm: {
                    text: info.ConfirmButton,
                    keys: ['enter'],
                    btnClass: 'btn-red',
                    action: function () {
                        var dataModel =
                        {
                            Id: info.Id,
                            Status: info.Status,
                            __RequestVerificationToken: info.RequestVerificationToken
                        };

                        jQuery.ajax({
                            url: info.Url,
                            type: "POST",
                            data: dataModel,
                            dataType: "json",
                            cache: false,
                            success: function (result) {
                                console.log(result);
                                if (!result.Code) {
                                    $.confirm({
                                        title: 'Thông báo',
                                        useBootstrap: false,
                                        type: 'blue',
                                        boxWidth: '500px',
                                        content: 'Cập nhật dữ liệu thành công',
                                        buttons: {
                                            confirm: {
                                                text: 'OK',
                                                btnClass: 'btn-blue',
                                                key: ['enter'],
                                                action: function () {
                                                    location.reload();
                                                }
                                            }
                                        }
                                    });
                                }
                                else {
                                    $.alert({
                                        title: 'Thông báo lỗi',
                                        content: result.ErrorMessage,
                                        useBootstrap: false,
                                        type: 'red',
                                        boxWidth: '500px'
                                    });
                                }
                            },
                            error: function (error) {
                                $.alert({
                                    title: info.errorTitle,
                                    content: info.errorContent,
                                    useBootstrap: false,
                                    type: 'red',
                                    boxWidth: '500px'
                                });
                            }
                        });
                    }
                },
                cancel: {
                    text: 'Hủy bỏ',
                    keys: ['esc'],
                    action: function () {
                        //close
                    }
                },
            }
        });
    }
}
