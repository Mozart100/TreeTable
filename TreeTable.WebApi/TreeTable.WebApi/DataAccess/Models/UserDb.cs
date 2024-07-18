using TreeTable.WebApi.DataAccess.Models;

namespace Chato.Server.DataAccess.Models;

public class User : EntityDbBase 
{
    public string UserName { get; set; }
    public int Age { get; set; }
    public string Description { get; set; }
    public string Gender { get; set; }
    public string[] Rooms { get; set; }
    public string ConnectionId { get; set; }

}

