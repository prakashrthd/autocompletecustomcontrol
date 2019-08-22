$(function () {
    baseURL = getBaseUrl();
    init();
});

function init() {

    //Contact mode dropdown
    let contactModeUrl = baseURL + "/Scripts/ipc_contact/ipc_contactmode.json";
    let ddlContactMode = $('.ddlContactmode');

    ddlContactMode.empty();

    $.getJSON(contactModeUrl, function (result) {
        $.each(result, function (key, entry) {
            ddlContactMode.append($('<option></option>').attr('value', entry).text(entry));
        });
    });


    //Country dropdown
    let countryListUrl = baseURL + "/Scripts/ipc_contact/ipc_countrycode.json";
    let ddlCountryList = $('.ddlCountry');

    ddlCountryList.empty();

    $.getJSON(countryListUrl, function (result) {
        $.each(result, function (key, entry) {
            ddlCountryList.append($('<option></option>').attr('value', entry.dial_code).text(entry.name + ' - ' + entry.dial_code).attr('mask', entry.mask));
        });
    });
};

function getBaseUrl() {
    return window.location.protocol + "//" + window.location.host;
};

function countryChange(ctrlCountry) {
    var selectedValue = $(ctrlCountry).val();
    alert(selectedValue);
};