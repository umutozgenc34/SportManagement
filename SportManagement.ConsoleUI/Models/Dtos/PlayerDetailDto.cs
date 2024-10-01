

using SportManagement.ConsoleUI.Models.Enums;

namespace SportManagement.ConsoleUI.Models.Dtos;

public record PlayerDetailDto(
        Guid Id,
        string Name,
        string Surname,
        string Number,
        Branch Branch,
        int Age,
        double MarketValue,
        Gender Gender,
        string teamName
    );

