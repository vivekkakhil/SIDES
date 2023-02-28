using Microsoft.AspNetCore.Mvc.Rendering;

namespace SIDES.ViewModels
{
    public class Prepare
    {
        public SidesRequestModel SidesRequest { get; set; }

        public SidesResponseModel SidesResponse { get; set; }

        public List<SelectListItem> SIDES_PREPARERTYPE { get; set; }

        public string PreparerCompanyName { get; set; }

        public string PreparerTelephoneNumberPlusExt { get; set;}

        public string PreparerContactName { get; set; }

        public string PreparerTitle { get; set; }

        public string PreparerFaxNbr { get; set; }

        public string PreparerEmailAddress { get; set; }

        public List<SelectListItem> SIDES_AMENDEDRESPONSE { get; set; }

        public string AmendedResponseDescription { get; set; }


    }
}
