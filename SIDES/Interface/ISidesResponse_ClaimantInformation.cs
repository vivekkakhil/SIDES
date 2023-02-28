using Microsoft.EntityFrameworkCore.Update.Internal;
using SIDES.ViewModels;
using SIDES.Services;

namespace SIDES.Interface
{
    public interface ISidesResponse_ClaimantInformation
    {
        public string GetRec();

        public int FlagRequestStatus(int RequestforSeparationId);//, "Pending");

        public void Update(ClaimantInformation ClaimModelUpdate);



    }
}
