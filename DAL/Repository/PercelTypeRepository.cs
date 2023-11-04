using DAL.IRepository;
using Models;

namespace DAL.Repository
{
    public class PercelTypeRepository : IPercelTypeRepository
    {
        public async Task<IEnumerable<PercelTypesModel>> GetAllData()
        {
            var query = "SELECT * FROM PercelTypes";
            
        }

        public Task<string> GetData()
        {
            throw new NotImplementedException();
        }
        public Task<string> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<string> SaveOrUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
