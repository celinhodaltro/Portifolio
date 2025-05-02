using Application.Main;
using Core.Provider;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

var baseElement = builder.HostEnvironment.BaseAddress;
#if !DEBUG
baseElement = "https://celinhodaltro.github.io/Portifolio/";
#endif
builder.Services.AddMudServices();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseElement) });


builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseInMemoryDatabase("InMemoryDb");
});

await builder.Build().RunAsync();
