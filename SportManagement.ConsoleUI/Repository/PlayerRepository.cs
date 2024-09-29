

using SportManagement.ConsoleUI.Models;
using SportManagement.ConsoleUI.Models.Dtos;

namespace SportManagement.ConsoleUI.Repository;

public sealed class PlayerRepository : IPlayerRepository
{
    public Player Add(Player entity)
    {
        BaseRepository.players.Add(entity);
        return entity;
    }

    public Player? Delete(Guid id)
    {
        Player player = GetById(id);
        if (player != null)
        {
            throw new Exception($"Aradığınız Id ye göre bir oyuncu bulunamadı : {id}");
        }
        BaseRepository.players.Remove(player);
        return player;
    }

    public List<Player> GetAll()
    {
        return BaseRepository.players;
    }

    public Player? GetById(Guid id)
    {
        Player? player = BaseRepository.players.SingleOrDefault(x => x.Id == id);
        if (player == null)
        {
            throw new Exception("Aradığınız Id ye göre oyuncu bulanamadı");
        }
        return player;
    }

    public Player? Update(Guid id, Player entity)
    {
        Player? player = GetById(id);
        if (player == null)
        {
            throw new Exception($"Aradığınız Id ye göre oyuncu Bulunamadı : {id}");
        }

        int index = BaseRepository.players.IndexOf(player);

        Player updatedPlayer = new()
        {
            Id = entity.Id,
            Age = entity.Age,
            Branch = entity.Branch,
            MarketValue = entity.MarketValue,
            Name = entity.Name,
            Number = entity.Number,
            Surname = entity.Surname,
            TeamId = entity.TeamId

        };

        BaseRepository.players.Remove(player);
        BaseRepository.players.Insert(index, updatedPlayer);

        return updatedPlayer;
    }

    public List<PlayerDetailDto> GetDetails(List<Team> teams)
    {
        List<PlayerDetailDto> details =
            BaseRepository.players.Join(teams,
            p => p.TeamId,
            t => t.Id,
            (pl, te) => new PlayerDetailDto(
                         Id: pl.Id,
                         teamName: te.Name,
                         Name: pl.Name,
                         Surname:pl.Surname,
                         Number:pl.Number,
                         Branch:pl.Branch,
                         Age: pl.Age,
                         MarketValue:pl.MarketValue

                         )
            ).ToList();
        return details;
    }
}
