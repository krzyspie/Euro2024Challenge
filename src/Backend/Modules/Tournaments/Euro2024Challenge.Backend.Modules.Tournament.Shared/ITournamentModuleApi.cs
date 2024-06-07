namespace Euro2024Challenge.Backend.Modules.Tournament.Shared;

public interface ITournamentModuleApi
{
    Task GetMatches(int[] matchIds);
    Task GetTeam(int id);
    Task GetFootballer(int id);
}