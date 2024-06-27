using Euro2024Challenge.Backend.Modules.Classification.Api;
using Euro2024Challenge.Backend.Modules.Players.Api;
using Euro2024Challenge.Backend.Modules.Tournaments.Api;
using Euro2024Challenge.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterPlayersModule();
builder.Services.RegisterTournamentsModule();
builder.Services.RegisterClassificationModule();
builder.Services.RegisterShared();

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UsePlayersModules();
app.UseTournamentsModules();
app.UseClassificationModules();

app.Run();
