using Euro2024Challenge.Backend.Modules.Players.Application.Players.DTO;
using Euro2024Challenge.Backend.Modules.Players.Domain.Entities;

namespace Euro2024Challenge.Backend.Modules.Players.Application.Extensions;

public static class PlayerExtensions
{
    public static PlayerDto ToPlayerDto(this Player player)
    {
        return new PlayerDto
        {
            Id = player.Id,
            Username = player.Username,
            Email = player.Email
        };
    }
}