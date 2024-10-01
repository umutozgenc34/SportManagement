using SportManagement.ConsoleUI.Models;
using SportManagement.ConsoleUI.Models.Enums;
using SportManagement.ConsoleUI.Services;

TeamService teamService = new TeamService();
Team newTeam = new Team(2,"Çaykur Rizespor",new DateTime(1953,1,18));
//teamService.GetAll();
//teamService.Add(newTeam);
//Console.WriteLine(teamService.GetById(5));
//Console.WriteLine(teamService.Delete(3));
//Console.WriteLine(teamService.Update(2,newTeam));
//teamService.GetAll();


PlayerService playerService = new PlayerService();
Player player = new(new Guid("{CA144940-8B49-4CB2-A7E3-D54A074AD502}"), "Umut", "Özgenç", "7", Branch.Football, 24, 3000000,Gender.Male ,1);
//playerService.GetDetails();
//playerService.GetAll();
//playerService.Add(player);
//Console.WriteLine(playerService.GetById(new Guid("{CA144940-8B49-4CB2-A7E3-D54A074AD504}")));
//Console.WriteLine(playerService.Delete(new Guid("{CA144940-8B49-4CB2-A7E3-D54A074AD508}")));
//Console.WriteLine(playerService.Update(new Guid("{CA144940-8B49-4CB2-A7E3-D54A074AD504}"), player));

//Console.WriteLine(teamService.GetById(3));
Console.WriteLine(teamService.GetById(200));