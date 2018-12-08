$.validator.addMethod("StartDateV", function (value, element, params) {
    console.log(value);
    var startDate = value;
    if (Date.parse(startDate) < Date.parse()) {
        return false;
    }
    return true;
});
$.validator.unobtrusive.adapters.add("StartDateV", function (options) {
    options.rules["StartDateV"] = "#" + options.params.otherpropertyname;
    options.messages["StartDateV"] = options.message;
});