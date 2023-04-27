using Microsoft.AspNetCore.Mvc.Rendering;
using System.Numerics;

namespace SIDES.ViewModels
{
    public class AttachmentResponse
    {

        public SidesRequestModel SidesRequest { get; set; }

        public SidesResponseModel SidesResponse { get; set; }

        public List<SelectListItem> SIDES_ATTACHMENTCODE { get; set; }

       /// <summary>
       /// public IFormFile AttachmentUpload { get; set; }
       /// </summary>

        public string TypeofDocument { get; set; }

        public string UniqueAttachmentID { get; set; }

        public long AttachmentSize { get; set; }

        public string UniqueAttachmentId { get; set; }

        public int DescriptionofAttachmentCode { get; set; }

        public string AttachmentData { get; set; }
    }
}
