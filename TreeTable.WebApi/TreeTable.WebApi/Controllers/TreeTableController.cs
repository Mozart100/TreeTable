using Microsoft.AspNetCore.Mvc;
using TreeTable.WebApi.Services;

namespace TreeTable.WebApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class TreeTableController : Controller
{
    public const string All_Rooms_Route = "all";
    public const string Room_Route = "{room}";
    private readonly IPeopleService _peopleService;

    public TreeTableController(IPeopleService peopleService)
    {
        this._peopleService = peopleService;
    }





    [HttpGet]
    public async Task<string> Status()
    {
        return "Its all good";
    }


    [Route("regions")]
    [HttpGet]
    public async Task<Tree> GetTree()
    {
        var response = await _peopleService.CreateFakePeopleTree();
        return response;
    }
}
