using WebApi.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.SnakeCaseLower;
});

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    var user = new User { FirstName = "Carlos", LastName = "Bolanos" };
    var result = new ApiResult<User> { Success = true, Data = user };
    return Results.Ok(result);
});

app.Run();
