using Models;

namespace DAL.IRepository
{
    public interface IPercelTypeRepository
    {
        Task<IEnumerable<PercelTypesModel>> GetAllData();
        Task<string> GetData();
        Task<string> SaveOrUpdate();
        Task<string> Delete();

    }
}
