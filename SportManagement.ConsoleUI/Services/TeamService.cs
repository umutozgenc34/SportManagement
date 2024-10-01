
using SportManagement.ConsoleUI.Exceptions;
using SportManagement.ConsoleUI.Models;
using SportManagement.ConsoleUI.Models.ReturnModels;
using SportManagement.ConsoleUI.Repository;
using System.Net;
using System.Threading.Channels;

namespace SportManagement.ConsoleUI.Services;

public class TeamService : ITeamService
{
    TeamRepository teamRepository = new TeamRepository();

    public ReturnModel<List<Team>> GetAll()
    {
        List<Team> list = teamRepository.GetAll();

        return new ReturnModel<List<Team>>
        {
            Data = list,
            Success = true,
            StatusCode = System.Net.HttpStatusCode.OK,
        };
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
                Success = true,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        catch (NotFoundException ex)
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = System.Net.HttpStatusCode.NotFound
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

    public ReturnModel<Team> Update(int id, Team team)
    {
        try
        {

            CheckTeamNameValidation(team.Name);


            teamRepository.Update(id, team);

            return new ReturnModel<Team>
            {
                Data = team,
                Message = "Takım Güncellendi",
                StatusCode = System.Net.HttpStatusCode.OK,
                Success = true
            };

        }
        catch (NotFoundException ex)
        {
            return ReturnModelOfException(ex);
        }
        catch (ValidationException ex)
        {
            return ReturnModelOfException(ex);
        }
    }

    private void CheckTeamNameValidation(string teamName)
    {
        if (teamName.Length < 1)
        {
            throw new ValidationException("İsim alanı minimum 1 haneli olmalıdır.");
        }
    }


    private ReturnModel<Team> ReturnModelOfException(Exception ex)
    {


        if (ex.GetType() == typeof(NotFoundException))
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = HttpStatusCode.NotFound
            };
        }

        if (ex.GetType() == typeof(ValidationException))
        {
            return new ReturnModel<Team>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = HttpStatusCode.BadRequest
            };
        }


        return new ReturnModel<Team>
        {
            Data = null,
            Message = ex.Message,
            Success = false,
            StatusCode = HttpStatusCode.InternalServerError
        };

    }


}
