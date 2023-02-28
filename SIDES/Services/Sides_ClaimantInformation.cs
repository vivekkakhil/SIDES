using Microsoft.EntityFrameworkCore;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.ViewModels;

namespace SIDES.Services
{
    public class Sides_ClaimantInformation : ISidesResponse_ClaimantInformation
    {
        private UCAContext _context;

        public Sides_ClaimantInformation(UCAContext uCAContext)
        {
            this._context = uCAContext; 
        }
        public int FlagRequestStatus(int RequestforSeparationId)
        {
            throw new NotImplementedException();
        }

        public string GetRec()
        {
            throw new NotImplementedException();
        }

        public void Update(ClaimantInformation ClaimModelUpdate)
        {

            int flag;
                ClaimantInformation ClaimModelUpdated = new ClaimantInformation();  

                SidesTparesponse ClaimModelNew = _context.SidesTparesponses.Where(b => b.RequestForSeparationId == ClaimModelUpdate.RequestForSeparationId).FirstOrDefault();
                if (ClaimModelNew != null)
                {

                    ClaimModelNew.ClaimantNameWorkedAsForEmployer = ClaimModelUpdate.OtherSSN;
                    ClaimModelNew.ClaimantJobTitle = ClaimModelUpdate.ClaimantJobTitle;
                    ClaimModelNew.SeasonalEmploymentInd = ClaimModelUpdate.SeasonalEmploymentInd;
                    ClaimModelNew.TotalEarnedWagesNeededInd = ClaimModelUpdate.TotalEarnedWagesNeededInd;
                ClaimModelNew.TotalEarnedWages = ClaimModelUpdate.TotalEarnedWages;
                ClaimModelNew.TotalWeeksWorked = ClaimModelUpdate.TotalWeeksWorked;
                ClaimModelNew.TotalWeeksWorkedNeededInd = ClaimModelUpdate.TotalWeeksWorkedNeededInd;
                ClaimModelNew.WagesEarnedAfterClaimEffectiveDate = ClaimModelUpdate.WagesEarnedAfterClaimEffectiveDate;
                ClaimModelNew.NumberOfHoursWorkedAfterClaimEffectiveDate = ClaimModelUpdate.NumberOfHoursWorkedAfterClaimEffectiveDate;
                ClaimModelNew.AverageWeeklyWage = ClaimModelUpdate.AverageWeeklyWage;
                    _context.SidesTparesponses.Update(ClaimModelNew);
                     flag =   _context.SaveChanges();

                    if (flag == 1)
                    {
                       
                       
                        var UpdatedCliam = _context.SidesTparesponses.Where(b => b.RequestForSeparationId == ClaimModelUpdate.RequestForSeparationId).FirstOrDefault();
                  

                     }
                }


           





        }
    }
}
