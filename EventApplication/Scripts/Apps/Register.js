$(function () {

    $(document).on("click", "#addOrder", function (e) {

        e.preventDefault();  // Stop the normal link click behaviour

        var currentUrl = $(this).attr("href");  // Get the url

        // Append the quantity value to query string
        var newUrl = currentUrl + "?quantity=" + $(this).find("option:selected").val();

        window.location.href = newUrl; ///Load the new page with all query strings
    });
});