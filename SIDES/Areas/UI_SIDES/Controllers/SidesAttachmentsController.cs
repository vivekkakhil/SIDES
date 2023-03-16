using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting.Internal;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.ViewModels;
using System.Diagnostics;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;

namespace SIDES.Areas.UI_SIDES.Controllers
{
    [Area("UI_SIDES")]
    public class SidesAttachmentsController : Controller
    {
        private UCAContext _UCAContext;
        private ISidesTPARequest _TPARequest;
        private readonly IFlagRequestStatus flagRequestStatus;
        private IWebHostEnvironment _hostingEnvironment;

        public SidesAttachmentsController(UCAContext uCAContext, IWebHostEnvironment hostingEnvironment, ISidesTPARequest TPARequest, IFlagRequestStatus flagRequestStatus)
        {
            this._UCAContext = uCAContext;
            this._TPARequest = TPARequest;
            this.flagRequestStatus = flagRequestStatus;
            this._hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Route("UI_SIDES/SidesAttachments/SidesAttachmentsV/{RSID}")]
        public IActionResult SidesAttachmentsV(int RSID)
        {
            try
            {

                var attachmentsModel = GetAttachmentsDetails(RSID);
                return View(attachmentsModel);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            
        }

        [HttpPost]
        [Route("UI_SIDES/SidesAttachments/SidesAttachmentsV/{RSID}")]
        public IActionResult SidesAttachmentsV(int RSID, string Save, string Next, string view, string delete, Attachments model, IFormFile AttachmentUpload)
        {
            try
            {
                if (!string.IsNullOrEmpty(Save))
                {
                    AttachmentSaveDetails(RSID, AttachmentUpload);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");

                }
                if (!string.IsNullOrEmpty(Next))
                {

                    AttachmentSaveDetails(RSID, AttachmentUpload);
                    flagRequestStatus.FlagRequestStatus(RSID, "Pending");
                    //  return Redirect("https://localhost:44389/ui_sides/sidesPrepare/sidesPrepareV/" + RSID);
                    return RedirectToAction("sidesPrepareV", "sidesPrepare", new { id = RSID, Area = "UI_SIDES" });
                }
                if (!string.IsNullOrEmpty(view))
                {
                    AttachmentViewDetails(RSID);

                }

                if (!string.IsNullOrEmpty(delete))
                {
                    DeleteAttachmentDetails(RSID);

                }
                var AttachmentModel = GetAttachmentsDetails(RSID);

                return View(AttachmentModel);
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }




        public Attachments GetAttachmentsDetails(int RSID)
        {

            Attachments attachments = new Attachments();
            attachments.SidesRequest = _TPARequest.GetRec(RSID);

            var Request = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID)
                .Select(e => new
                {
                    TPAResponseId = e.TparesponseId
                }).FirstOrDefault();


            var TPAResponseAttachment = _UCAContext.SidesTparesponseattachments.Where(e => e.TparesponseId == Request.TPAResponseId).FirstOrDefault();


            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var attachmentcode in _UCAContext.SidesAttachmentcodes)
            {
                if (TPAResponseAttachment != null)
                {
                    if (TPAResponseAttachment.DescriptionOfAttachmentCode == attachmentcode.AttachmentCodeId)
                        items.Add(new SelectListItem { Text = attachmentcode.AttachmentCode, Value = attachmentcode.AttachmentCodeId.ToString(), Selected = true });
                    else
                        items.Add(new SelectListItem { Text = attachmentcode.AttachmentCode, Value = attachmentcode.AttachmentCodeId.ToString() });
                }
                else
                {
                   items.Add(new SelectListItem { Text = attachmentcode.AttachmentCode, Value = attachmentcode.AttachmentCodeId.ToString() });
                }

            }

            attachments.SIDES_ATTACHMENTCODE = items;

            if (TPAResponseAttachment != null)
            {
                attachments.TypeofDocument = TPAResponseAttachment.TypeofDocument;
                if ((TPAResponseAttachment.UniqueAttachmentId == "") || (TPAResponseAttachment.UniqueAttachmentId == null))
                    attachments.UniqueAttachmentID = "01";
               else
                    attachments.UniqueAttachmentID = TPAResponseAttachment.UniqueAttachmentId.Trim();
                attachments.AttachmentSize = Convert.ToInt64(TPAResponseAttachment.AttachmentSize);
            }

            return attachments;

        }


        public void AttachmentSaveDetails(int RSID, IFormFile AttachmentUpload)
        {
            //if(AttachmentUpload == { .txt,.csv,.pdf})
            var Request = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID)
                .Select(e => new
                {
                    TPAResponseId = e.TparesponseId
                }).FirstOrDefault();

            var sidesTparesponse = _UCAContext.SidesTparesponseattachments.Where(e => e.TparesponseId == Request.TPAResponseId).FirstOrDefault();


            if (sidesTparesponse == null)
            {
                SidesTparesponseattachment sidesTparesponseattachment = new SidesTparesponseattachment
                {
                    TparesponseId = Request.TPAResponseId
                };
                

                _UCAContext.SidesTparesponseattachments.Add(sidesTparesponseattachment);
                _UCAContext.SaveChanges();


                sidesTparesponseattachment.TypeofDocument = HttpContext.Request.Form["TypeofDocument"].ToString();
                sidesTparesponseattachment.UniqueAttachmentId = HttpContext.Request.Form["UniqueAttachmentID"].ToString();
                sidesTparesponseattachment.ContentType = HttpContext.Request.Form["SIDESATTACHMENTCODE"].ToString();
                sidesTparesponseattachment.ContentType = AttachmentUpload.ContentType;
                string fileName = Path.GetFileName(AttachmentUpload.FileName);
                string contentType = AttachmentUpload.ContentType;
                using (MemoryStream ms = new MemoryStream())
                {
                    AttachmentUpload.CopyTo(ms);
                    sidesTparesponse.AttachmentData = ms.ToArray();
                }
                sidesTparesponseattachment.AttachmentSize = Convert.ToInt64(HttpContext.Request.Form["AttachmentSize"].ToString());
                _UCAContext.SidesTparesponseattachments.Update(sidesTparesponseattachment);
                _UCAContext.SaveChanges();


            }

            if (sidesTparesponse != null)
            {
                sidesTparesponse.TypeofDocument = HttpContext.Request.Form["TypeofDocument"].ToString();
                sidesTparesponse.UniqueAttachmentId = HttpContext.Request.Form["UniqueAttachmentID"].ToString();

                if(HttpContext.Request.Form["SIDESATTACHMENTCODE"].ToString() != "")
                sidesTparesponse.DescriptionOfAttachmentCode = Convert.ToInt32( HttpContext.Request.Form["SIDESATTACHMENTCODE"].ToString());
                if (AttachmentUpload != null)
                {
                    sidesTparesponse.ContentType = AttachmentUpload.ContentType;
                    string fileName = Path.GetFileName(AttachmentUpload.FileName);
                    string contentType = AttachmentUpload.ContentType;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        AttachmentUpload.CopyTo(ms);
                        sidesTparesponse.AttachmentData = ms.ToArray();
                    }
                    sidesTparesponse.AttachmentSize = Convert.ToInt64(HttpContext.Request.Form["AttachmentSize"].ToString());
                    _UCAContext.SidesTparesponseattachments.Update(sidesTparesponse);
                    _UCAContext.SaveChanges();
                }

            }
        
        }
        //if (ModelState.IsValid)
        //{
        //    string uniquefilefoldername;
        //    if (model.AttachmentUpload != null)
        //    {

        //        string DirPath = Path.Combine(_hostingEnvironment.WebRootPath, "Images");

        //        var data = model.AttachmentUpload;
        //        if (!Directory.Exists(DirPath))
        //        {
        //            Directory.CreateDirectory(DirPath);

        //        }
        //        model.AttachmentUpload.CopyTo(new FileStream(DirPath, FileMode.Create));

        //    }
        //}  


        [HttpGet]
        public ViewResult AttachmentViewDetails(int RSID)
        {
            var Request = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID)
         .Select(e => new
         {
             TPAResponseId = e.TparesponseId
         }).FirstOrDefault();

            var sidesTparesponse = _UCAContext.SidesTparesponseattachments.Where(e => e.TparesponseId == Request.TPAResponseId).FirstOrDefault();
          
            
            if (sidesTparesponse != null)
            {
                var uploadedfiles = _UCAContext.SidesTparesponseattachments.Where(e => e.TparesponseId.Equals(sidesTparesponse.TparesponseId)).First();
                if (uploadedfiles.AttachmentData != null)
                {
                    byte[] binaryString = uploadedfiles.AttachmentData;
                    string decodedString = Encoding.UTF8.GetString(binaryString);
                    System.IO.StreamWriter file = new System.IO.StreamWriter("c:/uisides/attachments/files/" + uploadedfiles.TypeofDocument + "");
                    file.Write(decodedString);
                    file.Close();
                }
            }
            
            ViewBag.Message = string.Format("Your Attachmnet file is downloaded in your directory .\\n file location : {0} ", "c:/uisides/attachments/files/");
            return View();
        }




        public void DeleteAttachmentDetails(int RSID)
        {
            var Request = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RSID)
                .Select(e => new
                {
                    TPAResponseId = e.TparesponseId
                }).FirstOrDefault();

            var sidesTparesponse = _UCAContext.SidesTparesponseattachments.Where(e => e.TparesponseId == Request.TPAResponseId).FirstOrDefault();

            if (sidesTparesponse != null)
            {
                sidesTparesponse.AttachmentData = null;
                sidesTparesponse.AttachmentSize = 0;
                sidesTparesponse.ContentType = null;
                sidesTparesponse.UniqueAttachmentId = null;
                sidesTparesponse.DescriptionOfAttachmentCode = 0;
                _UCAContext.SidesTparesponseattachments.Update(sidesTparesponse);

            }
            _UCAContext.SaveChanges();

        }
    }
}
