
$(document).ready(function () {
    var data = [
        {
            formCode: 531718,
            formName: 'Investment Form',
            fullName: 'Test User',
            appointmentDate: '13 March, 2017',
            appointmentTime: '1:30PM',
            phone: '9876543210',
            action: '<a href="#" class="btn btn-primary">Edit</a>'
        },
        {
            formCode: 531790,
            formName: 'Investment Fodarm 2',
            fullName: 'Test User',
            appointmentDate: '12 March, 2017',
            appointmentTime: '1:30PM',
            phone: '9876543210',
            action: '<a href="#" class="btn btn-primary">Edit</a>'
        }
    ]

    var columns = {
        'formCode': 'Form Code',
        'formName': 'Form Name',
        'fullName': 'Full Name',
        'appointmentDate': 'Appointment Date',
        'appointmentTime': 'Appointment Time',
        'phone': 'Phone',
        'action': 'Action'
    }
    $.get({
        url: "/Admin/ManageCDIO/Index",
        type: 'GET',
        success: function (res) {
            console.log(res);
            alert(res);
        }
    });
    var table = $("#table").tableSortable({
        data: data,
        columns: columns,
        rowsPerPage: 10,
        pagination: true
    });
});