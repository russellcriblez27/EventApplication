function searchFailed() {
    $("#EventSearch").html("No events found.");
}

$(function () {
    $(".RemoveLink").click(function () {
        alert("link clicked");
        var id = $(this).attr("data-id");
        $.post("/Order/RemoveOrder", { "id": id }, function (data) {
            //Populate elements in my view with data from the controller
            $("#update-message").text(data.Message);
            $("#status-" + id).text("Cancelled");
            $("#remove-" + id).empty();
            $("#order-" + id).append(html);
        });
    });
});