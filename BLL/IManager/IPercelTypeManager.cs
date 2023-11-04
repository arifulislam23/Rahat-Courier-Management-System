using Models;
namespace BLL.IManager
{
    public interface IPercelTypeManager
    {
        Task<IEnumerable<PercelTypesModel>> GetAllData();
        Task<string> GetData(int id);
        Task<string> SaveOrUpdateData(PercelTypesModel objPercelTypes);
        Task<string> Delete(int id);

    }
}
