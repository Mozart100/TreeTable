namespace TreeTable.WebApi.DataAccess.Models;


public class ChatRoomDb : EntityDbBase
{
    public override string Id
    {
        get => RoomName;
        set => RoomName = value;
    }
    public string RoomName { get; private set; }


}



