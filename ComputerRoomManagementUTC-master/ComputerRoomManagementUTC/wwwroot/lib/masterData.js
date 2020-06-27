var masterData = {

    GetComputerSelect2Data: (computerId) => {
        $.ajax({
            url: '/Computer/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });



                $("#" + computerId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },


    GetRamSelect2Data: (ramId) => {
        $.ajax({
            url: '/Ram/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + ramId).select2({
                    placeholder: "Select a Review",
                    data: data,
                    allowClear: true
                });
            }
        });
    },
    
    GetCpuSelect2Data: (cpuId) => {
        $.ajax({
            url: '/Cpu/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + cpuId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetKeyboardSelect2Data: (keyboardId) => {
        $.ajax({
            url: '/Keyboard/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + keyboardId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetMouseSelect2Data: (mouseId) => {
        $.ajax({
            url: '/Mouse/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + mouseId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetMonitorSelect2Data: (monitorId) => {
        $.ajax({
            url: '/Monitor/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + monitorId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetMonitorSizeSelect2Data: (monitorSizeId) => {
        $.ajax({
            url: '/MonitorSize/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + monitorSizeId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetSpeedSelect2Data: (speedId) => {
        $.ajax({
            url: '/Speed/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + speedId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetOpticalDiscSelect2Data: (opticalDiscId) => {
        $.ajax({
            url: '/OpticalDisc/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });


                $("#" + opticalDiscId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetStorageSelect2Data: (storageId) => {
        $.ajax({
            url: '/StorageDevice/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + storageId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetStorageCapacitySelect2Data: (storageCapacityId) => {
        $.ajax({
            url: '/StorageCapacity/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + storageCapacityId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetProvinceSelect2Data: (provinceId) => {
        $.ajax({
            url: '/Province/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });



                $("#" + provinceId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },
    GetComputerRoomSelect2Data: (computerRoomId) => {
        $.ajax({
            url: '/ComputerRoom/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });



                $("#" + computerRoomId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },
    GetTeacherSelect2Data: (teacherId) => {
        $.ajax({
            url: '/Teacher/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });



                $("#" + teacherId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },
    GetClassSelect2Data: (classId) => {
        $.ajax({
            url: '/Class/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });



                $("#" + classId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },
    GetEmployeeSelect2Data: (employeeId) => {
        $.ajax({
            url: '/Employee/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });



                $("#" + employeeId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },
    GetShiftSelect2Data: (shiftId) => {
        $.ajax({
            url: '/Shift/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                console.log(respone);

                $("#" + shiftId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },
    GetSubjectSelect2Data: (subjectId) => {
        $.ajax({
            url: '/Subject/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });



                $("#" + subjectId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },
}