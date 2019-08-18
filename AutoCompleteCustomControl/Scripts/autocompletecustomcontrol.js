
//attached autocomplete widget to all the autocomplete controls
$(document).ready(function () {
    BindAutoComplete();
});
function BindAutoComplete() {

    $('[data-autocomplete]').each(function (index, element) {
        var sourceurl = $(element).attr('data-sourceurl');
        var autocompletetype = $(element).attr('data-autocompletetype');
        $(element).autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: sourceurl,
                    dataType: "json",
                    data: { searchHint: request.term },
                    success: function (data) {
                        response($.map(data, function (item) {
                            if (autocompletetype == 'none') {
                                return {
                                    label: item.PatientName,
                                    value: item.PatientName,
                                    selectedValue: item.PatientId
                                };
                            }
                            else if (autocompletetype == 'lab') {
                                return {
                                    label: item.LabName,
                                    value: item.LabName,
                                    selectedValue: item.LabId

                                };//
                            }
                            else if (autocompletetype == 'patient') {
                                return {
                                     label: item.PatientName,
                                    value: item.PatientName,
                                    selectedValue: item.PatientId

                                };//
                            }
                        }));
                    },
                    error: function (data) {
                        alert(data);
                    },
                });
            },
            select: function (event, ui) {
                var valuetarget = $(this).attr('data-valuetarget');
                $("input:hidden[name='" + valuetarget + "']").val(ui.item.selectedValue);

                var selectfunc = $(this).attr('data-electfunction');
                if (selectfunc != null && selectfunc.length > 0) {
                   // window[selectfunc](event, ui);
                    //funName();
                    GetPatient(ui.item.selectedValue, ui.item.value);
                }
                //    selectfunc(event, ui);
            },
            change: function (event, ui) {
                var valuetarget = $(this).attr('data-valuetarget');


                $("input:hidden[name='" + valuetarget + "']").val('');
            },
        });
    });
};

function GetPatient(id, name) {
    alert("Hey! Patient name is " + name);
}