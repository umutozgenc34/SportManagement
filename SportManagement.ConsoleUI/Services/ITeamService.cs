

using SportManagement.ConsoleUI.Models.ReturnModels;
using SportManagement.ConsoleUI.Models;

namespace SportManagement.ConsoleUI.Services;

public interface ITeamService
{
    ReturnModel<Team> GetById(int id);
    ReturnModel<Team> Update(int id, Team team);
    ReturnModel<Team> Delete(int id);
}
