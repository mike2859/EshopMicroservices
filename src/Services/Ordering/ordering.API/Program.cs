var builder = WebApplication.CreateBuilder(args);

// Add services to the container (Injection)

var app = builder.Build();

// Configure the HTTP request pipeline

app.Run();
