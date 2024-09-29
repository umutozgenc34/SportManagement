

namespace SportManagement.ConsoleUI.Models.Dtos;

public record PlayerDetailDto(
        Guid Id,
        string Name,
        string Surname,
        string Number,
        string Branch,
        int Age,
        double MarketValue,
        string teamName
    );

