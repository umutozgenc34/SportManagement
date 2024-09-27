

namespace SportManagement.ConsoleUI.Models;

public sealed class Player : Entity<Guid>
{
    public Player()
    {
        
    }
    public Player(Guid id , string name , string surname, string number, string branch,int age, double marketValue, int teamId)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Number = number;
        Branch = branch;
        Age = age;
        MarketValue = marketValue;
        TeamId = teamId;        
    }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }
    public string Branch { get; set; }
    public int Age { get; set; }
    public double MarketValue { get; set; }
    public int TeamId { get; set; }

    public override string ToString()
    {
        return $"Id : {Id} Name : {Name} Surname : {Surname} Number : {Number} Branch : {Branch} Age : {Age} Market Value : {MarketValue} TeamId : {TeamId}";
    }
}
