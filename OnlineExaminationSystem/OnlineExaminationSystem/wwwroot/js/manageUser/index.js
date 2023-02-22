$(document).ready(function () {
    console.log('manage user index');
    $(".btn-delete-user").click(function () {
        if (confirm("Do you want to delete this user?")) {
            let userId = $(this).attr('user-id')

            $.ajax({
                url: "/Admin/ManageUser/Delete/" + userId,
                type: "GET",
                contentType: "application/json",
                success: function (res) {
                    console.log(res)
                }
            })
        }
        else {
        }
    })
});