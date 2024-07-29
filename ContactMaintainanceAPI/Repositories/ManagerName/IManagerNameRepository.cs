namespace ContactMaintainenceAPI.Repositories.ManagerName;

public interface IManagerNameRepository
{
    Task<IEnumerable<MagagerName>> GetAddManagerName();
    Task<MagagerName?> GetManagerNameById(int id);
}