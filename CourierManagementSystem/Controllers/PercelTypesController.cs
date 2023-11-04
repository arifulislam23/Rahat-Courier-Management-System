using BLL.IManager;
using Microsoft.AspNetCore.Mvc;

namespace CourierManagementSystem.Controllers
{
    public class PercelTypesController : Controller
    {
        private readonly IPercelTypeManager _manager;
        public PercelTypesController(IPercelTypeManager manager)
        {
            _manager= manager;
        }
        public async Task<IActionResult> Index()
        {
            var data= await _manager.GetAllData();
            return View(data);
        } 
    }
}
