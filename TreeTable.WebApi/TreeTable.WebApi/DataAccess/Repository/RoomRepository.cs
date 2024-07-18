using TreeTable.WebApi.DataAccess.Models;

namespace TreeTable.WebApi.DataAccess.Repository;

public interface IRoomRepository : IRepositoryBase<ChatRoomDb>
{
}

public class RoomRepository : RepositoryBase<ChatRoomDb>, IRoomRepository
{
    private readonly ILogger<RoomRepository> _logger;

    public RoomRepository(ILogger<RoomRepository> logger)
    {
        _logger = logger;
    }

}

