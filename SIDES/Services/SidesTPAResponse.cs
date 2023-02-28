using Microsoft.EntityFrameworkCore;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services.UI_SIDES.DTO;
using SIDES.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace SIDES.Services
{
    public class SidesTPAResponse : ISidesTPAResponse
    {
        private UCAContext _UCAContext;

        public SidesTPAResponse(UCAContext uCAContext)
        {
            _UCAContext = uCAContext;
        }

        public void FlagRequestStatus(int RequestForSeparationId, string RecordStatus)
        {
            /* var _savechanges = _UCAContext.SIDES_REQUESTFORSEPARATION.Where(e => e.RequestForSeparationId == RequestForSeparationId);
             foreach (var change in _savechanges)
             {
                 change.RecordStatus = RecordStatus;
             }

             _UCAContext.SaveChanges(); */

            throw new NotImplementedException();
        }

      

     public   SidesResponseModel GetRec(int RequestforSeparationId)
        {

            SidesResponseModel _sidesTPAResponseModel = new SidesResponseModel();

            var _sidesresponsemodel = _UCAContext.SidesRequestforseparations.Where(e => e.RequestForSeparationId == RequestforSeparationId).ToList();
            var _updatedsidesresponsemodel = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RequestforSeparationId).FirstOrDefault();

            _sidesresponsemodel.ForEach(s =>
            {
                SidesResponseModel _sidesResponseModel = new SidesResponseModel();

                _sidesResponseModel.RequestForSeparationId = s.RequestForSeparationId;
                _sidesResponseModel.SSN = Convert.ToDecimal(s.Ssn);
                _sidesResponseModel.ClaimNumber = s.ClaimNumber;
                _sidesResponseModel.ClaimantLastName = s.ClaimantLastName;
                _sidesResponseModel.ClaimEffectiveDate = DateOnly.FromDateTime((DateTime)s.ClaimEffectiveDate); //need to check the data for the result
                _sidesResponseModel.RequestingStateAbbreviation = s.RequestingStateAbbreviation;
                _sidesResponseModel.ClaimantOtherLastName = s.ClaimantLastName;
                _sidesResponseModel.EmployerName = s.EmployerName;
                _sidesResponseModel.StateEmployerAccountNbr = s.StateEmployerAccountNbr;
                _sidesResponseModel.FEIN = s.Fein;

                _sidesResponseModel.CorrectedStateEmployerAccountNbr = _updatedsidesresponsemodel.CorrectedStateEmployerAccountNbr;
                _sidesResponseModel.CorrectedEmployerName = _updatedsidesresponsemodel.CorrectedEmployerName;
                _sidesResponseModel.CorrectedFEIN = _updatedsidesresponsemodel.CorrectedFein;
                


                var UIoffice = _UCAContext.Uioffices.Where(e => e.UiofficeId == s.UiofficeId).FirstOrDefault();
                if (UIoffice != null)
                {
                    _sidesResponseModel.ClaimantUIOffice.UIOfficeId = UIoffice.UiofficeId;
                    _sidesResponseModel.ClaimantUIOffice.UIOfficeFax = UIoffice.UiofficeFax;
                    _sidesResponseModel.ClaimantUIOffice.UIOfficePhone = UIoffice.UiofficePhone;
                    _sidesResponseModel.ClaimantUIOffice.UIOfficeName = UIoffice.UiofficeName;
                }
                _sidesTPAResponseModel = _sidesResponseModel;
            });
            return _sidesTPAResponseModel;
        }

       public SidesResponseModel SaveDetails(int RequestForSeparationId, SidesResponseModel SidesResponseChanges)
        {
            bool flag;
            var SidesRequest = _UCAContext.SidesTparesponses.Where(e => e.RequestForSeparationId == RequestForSeparationId).FirstOrDefault();

            if (SidesResponseChanges.RequestForSeparationId != null)
            {
                //SidesResponseChanges.EmployerName = HttpContext.Request.Form["fname"].ToString(); ;
                //SidesResponseChanges.StateEmployerAccountNbr = ;
                //SidesResponseChanges.Fein = ;
                //SidesResponseChanges.CreatedBy = "test";
                SidesResponseChanges.CreatedDate = DateTime.Now;
                //SidesResponseChanges.RequestForSeparationId = RequestForSeparationId;

              
              
                SidesRequest.CreatedDate = DateTime.Now;
                SidesRequest.CorrectedEmployerName = SidesResponseChanges.CorrectedEmployerName;
                SidesRequest.CorrectedStateEmployerAccountNbr = SidesResponseChanges.CorrectedStateEmployerAccountNbr;
                SidesRequest.CorrectedFein = SidesResponseChanges.CorrectedFEIN;



                _UCAContext.SidesTparesponses.Update(SidesRequest);
                _UCAContext.SaveChanges();
                return SidesResponseChanges;

            }
            else
            {
                // var _SidesResponse = _UCAContext.SIDES_TPARESPONSE.Where(e => e.RequestForSeparationId == RequestForSeparationId).FirstOrDefault();
                SidesRequest.CreatedBy = "test";
                SidesRequest.CreatedDate = DateTime.Now;
                //updation of the result 
                //   var sidesresponse = _UCAContext.SidesTparesponses.Attach(SidesResponseChanges);
                //  sidesresponse.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                // _UCAContext.SidesTparesponses.Update(SidesResponseChanges);
                _UCAContext.SidesTparesponses.Update(SidesRequest);
                _UCAContext.SaveChanges();
            }
            return SidesResponseChanges;

        }



    }
}
