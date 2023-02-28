using SIDES.Services;
using SIDES.ViewModels;

namespace SIDES.Interface
{
    public interface ISidesTPAResponse
    {
        public SidesResponseModel GetRec(int RequestforSeparationId);

        public SidesResponseModel SaveDetails(int RequestForSeparationId, SidesResponseModel sidesresponsemodel);


        void FlagRequestStatus(int RequestForSeparationId, string RecordStatus);

    }
}
