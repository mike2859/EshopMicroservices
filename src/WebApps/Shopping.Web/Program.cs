var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

/*
var baseAddress = "http://address-goes-here/";

builder.Services.AddScoped(sp =>
{
    var client = new HttpClient();
    client.BaseAddress = new Uri(baseAddress);
    return client;
});


services.AddRefitClient<ICurrencyApi>()
                   .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.exchangeratesapi.io/"))
                   .SetHandlerLifetime(TimeSpan.FromMinutes(2));
*/


builder.Services.AddRefitClient<ICatalogService>()
    .ConfigureHttpClient(c =>
    {
        //c.BaseAddress = new Uri(builder.Configuration["ApiSettings.GatewayAddress"]!);
        c.BaseAddress = new Uri("https://localhost:6064");
    });



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
