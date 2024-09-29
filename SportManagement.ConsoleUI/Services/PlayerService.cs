

using SportManagement.ConsoleUI.Models;
using SportManagement.ConsoleUI.Models.Dtos;
using SportManagement.ConsoleUI.Models.ReturnModels;
using SportManagement.ConsoleUI.Repository;

namespace SportManagement.ConsoleUI.Services;

public class PlayerService : IPlayerService
{
    PlayerRepository playerRepository = new PlayerRepository();
    

    public void GetAll()
    {
        List<Player> players = playerRepository.GetAll();
        players.ForEach(x=> Console.WriteLine(x));

    }

    public void Add(Player player)
    {
        Player newPlayer = playerRepository.Add(player);
        Console.WriteLine("Yeni oyuncu eklendi\n" +
            "***** TÜM OYUNCULAR *****");
        GetAll();
    }

    public ReturnModel<Player> Delete(Guid id)
    {
        try
        {
            Player player = playerRepository.GetById(id);
            return new ReturnModel<Player>
            {
                Data = player,
                Message = $"Aradığınız Id ye göre oyuncu silindi {player}",
                Success = true
            };
        }
        catch (Exception ex)
        {
            return new ReturnModel<Player>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
            };

        }
    }

    public ReturnModel<Player> GetById(Guid id)
    {
        try
        {
            Player player = playerRepository.GetById(id);
            return new ReturnModel<Player>
            {
                Data = player,
                Message = $"Aradığınız Id ye göre oyuncu bulundu {player}",
                Success = true
            };
        }
        catch (Exception ex)
        {
            return new ReturnModel<Player>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
            };
            
        }
    }

    public ReturnModel<Player> Update(Guid id, Player player)
    {
        try
        {
            Player updatedPlayer = playerRepository.Update(id, player);
            return new ReturnModel<Player>
            {
                Data = updatedPlayer,
                Message = $"Aradığınız Id ye ait oyuncu güncellendi: {id}",
                Success = true
            };
        }
        catch (Exception ex)
        {
            return new ReturnModel<Player>
            {
                Data = null,
                Message = ex.Message,
                Success = false
            };
        }
    }

    public void GetDetails()
    {
        List<Team> teams = BaseRepository.teams;
        List<PlayerDetailDto> details = playerRepository.GetDetails(teams);
        details.ForEach(x => Console.WriteLine(x));
    }


}
