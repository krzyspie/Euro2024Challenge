using Euro2024Challenge.Backend.Modules.Players.Api;
using Euro2024Challenge.Backend.Modules.Turnaments.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterPlayersModule();
builder.Services.RegisterTurnamentsModule();

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UsePlayersModules();
app.Run();
