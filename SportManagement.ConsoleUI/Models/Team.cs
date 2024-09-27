

namespace SportManagement.ConsoleUI.Models;

public sealed class Team : Entity<int>
{
    public Team()
    {
        
    }

    public Team(int id,string name, DateTime since)
    {
        Id = id;
        Name = name;
        Since = since;
    }

    public string Name { get; set; }
    public DateTime Since { get; set; }

    public override string ToString()
    {
        return $" Id : {Id} Name : {Name} Since : {Since}";
    }

}
