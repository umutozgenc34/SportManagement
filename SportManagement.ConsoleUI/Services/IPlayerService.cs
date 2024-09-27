

using SportManagement.ConsoleUI.Models.ReturnModels;
using SportManagement.ConsoleUI.Models;

namespace SportManagement.ConsoleUI.Services;

public interface IPlayerService
{
    ReturnModel<Player> GetById(Guid id);
    ReturnModel<Player> Update(Guid id, Player player);
    ReturnModel<Player> Delete(Guid id);
}
