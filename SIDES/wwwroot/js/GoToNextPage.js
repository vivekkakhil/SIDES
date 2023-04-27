
function GoToNextPageDDL() {

    let q = document.getElementById("RouteId").value;

    // let urlSearchParams = window.location.href;
    //  let q = urlSearchParams.split('=')[1];
    output = document.querySelector('#GotopageNext');
    ddlvalue = output.value;



    if (ddlvalue == "0") {

        window.location.href = "http://test.evadvantage.com/ui_sides/sidesrequest/sidesrequestv";
    }
    else if (ddlvalue == "1") {

      

        window.location.href = "http://test.evadvantage.com/ui_sides/sidesResponse/sidesResponsev/" + q;

    }
    else if (ddlvalue == "2") {

        window.location.href = "http://test.evadvantage.com/ui_sides/sidesClaimantInformation/sidesClaimantInformationv/" + q;
    }
    else if (ddlvalue == "3") {

        window.location = "http://test.evadvantage.com/ui_sides/sidesReasonforSeparation/sidesReasonforSeparationv/" + q;
    }
    else if (ddlvalue == "4") {
        window.location = "http://test.evadvantage.com/ui_sides/sidesRemuneration/sidesRemunerationv/" + q;

    }
    else if (ddlvalue == "5") {
        window.location = "http://test.evadvantage.com/ui_sides/sidesDischarge/sidesDischargev/" + q;

    }

    else if (ddlvalue == "6") {
        window.location = "http://test.evadvantage.com/ui_sides/sidesprior/sidespriorv/" + q;

    }
    else if (ddlvalue == "7") {
        window.location = "http://test.evadvantage.com/ui_sides/sidesvoluntary/sidesvoluntaryv/" + q;

    }
    else if (ddlvalue == "8") {
        window.location = "http://test.evadvantage.com/ui_sides/sidesAttachments/sidesAttachmentsv/" + q;

    }
    else if (ddlvalue == "9") {


        window.location = "http://test.evadvantage.com/ui_sides/sidesPrepare/sidesPreparev/" + q;

    }
    else {


    }









}

function CancelClick() {




    window.location.href = "http://test.evadvantage.com/ui_sides/sidesrequest/sidesrequestv";

}


