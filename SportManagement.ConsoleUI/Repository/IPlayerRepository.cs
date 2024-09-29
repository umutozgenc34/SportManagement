using SportManagement.ConsoleUI.Models;
using SportManagement.ConsoleUI.Models.Dtos;


namespace SportManagement.ConsoleUI.Repository;

public interface IPlayerRepository : IRepository<Player,Guid>
{
    public List<PlayerDetailDto> GetDetails(List<Team> teams);
}
