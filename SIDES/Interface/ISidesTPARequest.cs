using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Services;
using SIDES.ViewModels;

namespace SIDES.Interface
{
    public interface ISidesTPARequest 
    {
        public  List<SidesRequestModel> GetAll(string Go,string Cancel,string EmployeeText = "", string EmployerText = "", DateTime? RequestDate = null, DateTime? ResponseDueDate = null , int pg =  1);

        public SidesRequestModel GetRec(int RequestforSeparationId);

        
    }

    

}

