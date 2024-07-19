using Microsoft.AspNetCore.Mvc;

namespace TreeTable.WebApi.Controllers;


    [Route("api/[controller]")]
    [ApiController]
    public class TreeTableController : Controller
    {
        public const string All_Rooms_Route = "all";
        public const string Room_Route = "{room}";


    [HttpGet]
    public async Task<string> Status()
    {
        return "Its all good";
    }
}
