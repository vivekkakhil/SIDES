using Microsoft.AspNetCore.Mvc.Rendering;
using System.Numerics;
using System.Xml.Serialization;

namespace SIDES.ViewModels
{
    public class Attachments
    {
        public SidesRequestModel SidesRequest { get; set; }

        public SidesResponseModel SidesResponse { get; set; }

        public List<SelectListItem> SIDES_ATTACHMENTCODE { get; set; }

        public IFormFile AttachmentUpload { get; set; }

        public string TypeofDocument { get; set; }

        public string UniqueAttachmentID { get; set; }

        public BigInteger AttachmentSize { get; set; }

        public string UniqueAttachmentId { get; set; }

        public int DescriptionofAttachmentCode { get; set; }

      //  [XmlIgnore]
       // public Byte[] AttachmentData {get;set;}
    }
}
