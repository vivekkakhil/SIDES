using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;

namespace SIDES.Services
{
    public class SidesResponse_Wagesavailability : ISidesResponse_Wagesavailability
    {
        private readonly UCAContext _uCAContext;

        public SidesResponse_Wagesavailability(UCAContext uCAContext)
        {
            _uCAContext = uCAContext;
        }

        public IEnumerable<ISidesResponse_Wagesavailability> GetAllResponses()
        {
            throw new NotImplementedException();
        }

    }
}
