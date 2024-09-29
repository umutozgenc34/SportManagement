

using SportManagement.ConsoleUI.Models;

namespace SportManagement.ConsoleUI.Repository;

public abstract class BaseRepository
{
    public static List<Team> teams = new List<Team>()
    {
        new Team
        {
            Id = 1,
            Name = "Beşiktaş",
            Since= new DateTime(1903,3,3)
        },
        new Team
        {
            Id = 2,
            Name = "Fenerbahçe",
            Since= new DateTime(1907,5,12)
        },
        new Team
        {
            Id = 3,
            Name = "Galatasaray",
            Since= new DateTime(1905,10,26)
        }


    };

    public static List<Player> players = new List<Player>()
    {
        new Player
        {
            Id = new Guid("{CA144940-8B49-4CB2-A7E3-D54A074AD504}"),
            Name = "Rafa",
            Surname = "Silva",
            Number = "27",
            Branch = "Futbol",
            Age = 32,
            MarketValue = 10000000,
            TeamId = 1
            

        },
        new Player
        {
            Id = new Guid("{CA144940-8B49-4CB2-A7E3-D54A074AD508}"),
            Name = "Eda",
            Surname = "Erdem",
            Number = "34",
            Branch = "Voleybol",
            Age = 35,
            MarketValue = 350000,
            TeamId = 2
        },
        new Player
        {
            Id = new Guid("{CA144940-8B49-4CB2-A7E3-D54A074AD506}"),
            Name = "Fernando",
            Surname = "Muslera",
            Number = "1",
            Branch = "Futbol",
            Age = 36,
            MarketValue = 950000,
            TeamId = 3
        },
    };
}
