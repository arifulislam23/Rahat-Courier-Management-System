using BLL.IManager;
using DAL.IRepository;
using Models;

namespace BLL.Manager
{
    public class PercelTypeManager : IPercelTypeManager
    {
        private readonly IPercelTypeRepository _repository;
        public PercelTypeManager(IPercelTypeRepository repository)
        {
            _repository= repository;
        }
        public async Task<IEnumerable<PercelTypesModel>> GetAllData()
        {
            try
            {
                var data= await _repository.GetAllData();
                return data;
            }
            catch(Exception) 
            {
                return null;
            }
        }
        public async Task<string> GetData(int id)
        {
            try
            {
                var data = await _repository.GetData(id);
                return data;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public async Task<string> SaveOrUpdateData(PercelTypesModel objPercelTypes)
        {
            try
            {
                var data = await _repository.SaveOrUpdate(objPercelTypes);
                return data;
            }
            catch(Exception)
            {
                return "Something went wrong";
            }
        }
        public async Task<string> Delete(int id)
        {
            try
            {
                var data= await _repository.Delete(id)
            }
            catch(Exception)
            {

            }
        }
        
    }
}
