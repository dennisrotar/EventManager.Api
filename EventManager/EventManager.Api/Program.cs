using EventManager.Api.Interfaces;
using EventManager.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Подключаем Problem Details для красивых ошибок.
builder.Services.AddProblemDetails();

// Регистрация сервиса в DI как Singleton (чтобы список событий не обнулялся).
builder.Services.AddSingleton<IEventService, EventService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
