using Microsoft.AspNetCore.Mvc;
using PassManagerAPI.DTO.Input;
using PassManagerAPI.DTO.Output;
using PassManagerAPI.Entities;
using PassManagerAPI.Infra.Context;
using PassManagerAPI.Infra.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IPassContext, PassContext>();
builder.Services.AddSingleton<IPassRepository, PassRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/pass", async ([FromServices] IPassRepository repository, [FromBody] PasswordInput input) =>
{
    input.Validate();

    Password entity = input;

    await repository.AddAsync(entity);

    return Results.NoContent();
})
.WithOpenApi();

app.MapGet("/pass", async ([FromServices] IPassRepository repository) =>
{
    var response = await repository.GetAsync();

    var output = response.Select(p => PasswordOutput.FromEntity(p));

    return Results.Ok(output);
})
.WithOpenApi();

app.Run();
