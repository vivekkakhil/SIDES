using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Services;
using SIDES.ViewModels;

namespace SIDES.Interface
{
    public interface ISidesTPARequest 
    {
        public  List<SidesRequestModel> GetAll();

        public SidesRequestModel GetRec(int RequestforSeparationId);
    }

    

}

