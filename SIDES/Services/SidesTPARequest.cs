using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services.UI_SIDES.DTO;
using SIDES.ViewModels;

namespace SIDES.Services
{
    public class SidesTPARequest : ISidesTPARequest
    {
        private readonly UCAContext _UCAContext;

        public SidesTPARequest(UCAContext uCAContext)
        {
            _UCAContext = uCAContext;

        }

        public List<SidesRequestModel> GetAll(string Go, string Cancel,string EmployeeText = "", string EmployerText = "", DateTime? RequestDate = null  , DateTime? ResponseDueDate = null , int pg = 1)
        {

            List<SidesRequestforseparation> sides;

            List<SidesRequestModel> _sidesRequestModels = new List<SidesRequestModel>();

            if ((!string.IsNullOrEmpty(Go)) )
            {

                if (((EmployeeText != "") && (EmployeeText != null)) || ((EmployerText != "") && (EmployerText != null)) || ((RequestDate != null) && (ResponseDueDate != null)))
                {
                    sides = _UCAContext.SidesRequestforseparations.Where(e => e.ClaimantFirstName.Contains(EmployeeText) || e.ClaimNumber.Contains(EmployeeText) || e.Ssn.ToString().Contains(EmployeeText) || e.EmployerName.Contains(EmployerText) || (e.RequestDate > RequestDate && e.ResponseDueDate < ResponseDueDate)).ToList();
                }
                else
                    sides = _UCAContext.SidesRequestforseparations.OrderBy(b => b.RequestForSeparationId).ToList();


                return SidesRequestTransfer(sides, _sidesRequestModels);
            }
            else if (!string.IsNullOrEmpty(Cancel))
            {

                sides = _UCAContext.SidesRequestforseparations.OrderBy(b => b.RequestForSeparationId).ToList();

                return SidesRequestTransfer(sides, _sidesRequestModels);
            }
            else if (((pg != null) && (pg >= 1)))
            {
                if (((EmployeeText != "") && (EmployeeText != null)) || ((EmployerText != "") && (EmployerText != null)) || ((RequestDate != null) && (ResponseDueDate != null)))
                {
                    sides = _UCAContext.SidesRequestforseparations.Where(e => e.ClaimantFirstName.Contains(EmployeeText) || e.ClaimNumber.Contains(EmployeeText) || e.Ssn.ToString().Contains(EmployeeText) || e.EmployerName.Contains(EmployerText) || (e.RequestDate > RequestDate && e.ResponseDueDate < ResponseDueDate)).ToList();
                }
                else
                    sides = _UCAContext.SidesRequestforseparations.OrderBy(b => b.RequestForSeparationId).ToList();


                return SidesRequestTransfer(sides, _sidesRequestModels);

            }
            else
            {
                sides = _UCAContext.SidesRequestforseparations.OrderBy(b => b.RequestForSeparationId).ToList();

                return SidesRequestTransfer(sides, _sidesRequestModels);
            }
            
           



            

           // return _sidesRequestModels;

            //  throw new NotImplementedException();

        }

        public SidesRequestModel GetRec(int RSID)
        {
            
           
          var  sidesrequestmodel = _UCAContext.SidesRequestforseparations.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

            
            SidesRequestModel sidesRequestModel = new SidesRequestModel();
            if (sidesrequestmodel != null)
            {
                sidesRequestModel.RequestForSeparationId = sidesrequestmodel.RequestForSeparationId;
                sidesRequestModel.ClaimNumber = sidesrequestmodel.ClaimNumber;
                sidesRequestModel.SSN = Convert.ToDecimal(sidesrequestmodel.Ssn);
                sidesRequestModel.FEIN = sidesrequestmodel.Fein;
                sidesRequestModel.ClaimantFirstName = sidesRequestModel.ClaimantFirstName;
                sidesRequestModel.ClaimantLastName = sidesRequestModel.ClaimantLastName;
                sidesRequestModel.EmployerName = sidesRequestModel.EmployerName;


                sidesRequestModel.RequestDate = DateOnly.FromDateTime(sidesrequestmodel.RequestDate);
                sidesRequestModel.ResponseDueDate = DateOnly.FromDateTime(sidesrequestmodel.ResponseDueDate);
                sidesRequestModel.Status = sidesRequestModel.Status;
                sidesRequestModel.RecordStatus = sidesRequestModel.RecordStatus;
            }
             return sidesRequestModel;
            


        }


        public List<SidesRequestModel> SidesRequestTransfer(List<SidesRequestforseparation> sides, List<SidesRequestModel> _sidesRequestModels)
        {

            sides.ForEach(s =>
            {
                SidesRequestModel sidesRequestModel = new SidesRequestModel();

                sidesRequestModel.RequestForSeparationId = s.RequestForSeparationId;
                sidesRequestModel.ClaimNumber = s.ClaimNumber;
                sidesRequestModel.SSN = Convert.ToInt32(s.Ssn);
                sidesRequestModel.FEIN = s.Fein;
                sidesRequestModel.ClaimantFirstName = s.ClaimantFirstName;
                sidesRequestModel.ClaimantLastName = s.ClaimantLastName;
                sidesRequestModel.EmployerName = s.EmployerName;

                sidesRequestModel.RequestDate = DateOnly.FromDateTime(s.RequestDate);
                sidesRequestModel.ResponseDueDate = DateOnly.FromDateTime(s.ResponseDueDate);
                sidesRequestModel.Status = s.Status;
                sidesRequestModel.RecordStatus = s.RecordStatus;

                _sidesRequestModels.Add(sidesRequestModel);

            });

            return _sidesRequestModels;
        }

        
    }
}
