$(function () {
    $("#uploadEditorImage").change(function () {
        var files = $("#uploadEditorImage").get(0).files;
        if (files.length === 0) {
            return;
        }
        var data = new FormData();
        data.append("itemId", "1");
        data.append("HelpSectionImages", files[0]);
        var labelButton = $(this).parent();
        labelButton.addClass('disabled');
        $("#status").text("Waiting...");
        $.ajax({
            url: '/home/uploadimage',
            type: "POST",
            data: data,
            dataType: "json",
            processData: false,
            contentType: false,
            success: function (data) {               
                labelButton.removeClass('disabled');
                $("#status").text("Completed OK.");
            },
            error: function (response, status, errorText) {
                labelButton.removeClass('disabled');
                $("#status").text("Completed with error.");
            }
        });
    });
});