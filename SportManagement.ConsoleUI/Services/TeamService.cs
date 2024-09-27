
using SportManagement.ConsoleUI.Models;
using SportManagement.ConsoleUI.Models.ReturnModels;
using SportManagement.ConsoleUI.Repository;
using System.Threading.Channels;

namespace SportManagement.ConsoleUI.Services;

public class TeamService : ITeamService
{
    TeamRepository teamRepository = new TeamRepository();
    public void GetAll()
    {
        List<Team> teams = teamRepository.GetAll();
        teams.ForEach(x=> Console.WriteLine(x));
    }

    public void Add (Team team)
    {
        Team newTeam = teamRepository.Add(team);
        Console.WriteLine($"Yeni takım eklendi {newTeam}");
        Console.WriteLine("*****TÜM TAKIMLAR*****");
        GetAll();
    }

    public ReturnModel<Team> GetById(int id)
    {
        try
        {
            Team team = teamRepository.GetById(id);
            return new ReturnModel<Team>
            {
                Data = team,
                Message = $"Aradığınız Id ye ait takım görüntülendi: {id}",
                Success = true
            };
        }
        catch (Exception ex)
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false
            };
        }

    }

    public ReturnModel <Team> Delete(int id)
    {
        
        try
        {
            Team team = teamRepository.Delete(id);
            return new ReturnModel<Team>
            {
                Data = team,
                Message = $"Aradığınız Id ye ait takım silindi: {id}",
                Success = true
            };

            
        }catch (Exception ex)
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false
            };
        }
        
    }

    public ReturnModel<Team> Update(int id ,Team team)
    {
        try
        {
            Team updatedTeam = teamRepository.Update(id, team);
            return new ReturnModel<Team>
            {
                Data = updatedTeam,
                Message = $"Aradığınız Id ye ait takım güncellendi: {id}",
                Success = true
            };
        }catch(Exception ex)
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false
            };
        }
    }
}
