using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;

namespace SIDES.Services
{
    public class FlagRequestStatus : IFlagRequestStatus
    {
        private UCAContext _UCAContext;

        public FlagRequestStatus(UCAContext uCAContext)
        {
            this._UCAContext = uCAContext;
        }

        void IFlagRequestStatus.FlagRequestStatus(int RSID, string Status)
        {
            // throw new NotImplementedException();

            var SidesRequestForSeparation = _UCAContext.SidesRequestforseparations.Where(e => e.RequestForSeparationId == RSID).FirstOrDefault();

            if(Status != "")
            SidesRequestForSeparation.RecordStatus = Status;

            _UCAContext.SidesRequestforseparations.Update(SidesRequestForSeparation);
            _UCAContext.SaveChanges();
        }
    }
}
