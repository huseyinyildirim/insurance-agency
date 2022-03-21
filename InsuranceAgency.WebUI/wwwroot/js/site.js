// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    var plate = $("#Plate");
    var tcId = $("#TCId");

    plate.blur(function () {
        licenseQuery();
    });

    tcId.blur(function () {
        licenseQuery();
    });

    function licenseQuery() {
        if (plate.val() && tcId.val()) {
            $.ajax({
                type: "POST",
                url: "/Home/License",
                data: {
                    "Plate": plate.val(),
                    "TCId": tcId.val(),
                },
                success: function (response) {
                    console.log(response);

                    if (response.data) {
                        $("#LicenseSerialCode").val(response.data.licenseSerialCode);
                        $("#LicenseSerialNo").val(response.data.licenseSerialNo);
                    }
                },
                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (response) {
                    alert(response.responseText);
                }
            });
        }
    }
});