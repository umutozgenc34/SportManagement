using SportManagement.ConsoleUI.Models;


namespace SportManagement.ConsoleUI.Repository;

public sealed class TeamRepository : ITeamRepository
{
    public Team Add(Team entity)
    {
        BaseRepository.teams.Add(entity);
        return entity;
    }

    public Team? Delete(int id)
    {
        Team? team = GetById(id);
        if (team == null)
        {
            throw new Exception($"Aradığınız Id ye göre Takım Bulunamadı:{id}");
        }
        BaseRepository.teams.Remove(team);
        return team;
    }

    public List<Team> GetAll()
    {
        return BaseRepository.teams;
    }

    public Team? GetById(int id)
    {
        Team? team = BaseRepository.teams.SingleOrDefault(p => p.Id == id);
        if (team == null)
        {
            throw new Exception($"Aradığınız Id ye göre Takım Bulunamadı:{id}");
        }
        return team;
    }

    public Team? Update(int id, Team entity)
    {
        Team? team = GetById(id);
        if (team == null)
        {
            throw new Exception($"Aradığınız Id ye göre Takım Bulunamadı : {id}");
        }

        int index = BaseRepository.teams.IndexOf(team);

        Team updatedTeam = new()
        {
            Id = entity.Id,
            Name = entity.Name,
            Since = entity.Since

        };

        BaseRepository.teams.Remove(team);
        BaseRepository.teams.Insert(index, updatedTeam);

        return updatedTeam;
    }
}





