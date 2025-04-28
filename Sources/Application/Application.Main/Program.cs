using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PortifolioApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Aqui começa o truque:
var baseElement = builder.HostEnvironment.BaseAddress;
#if !DEBUG
// Em produção (GitHub Pages), altere o base href
    baseElement = "https://celinhodaltro.github.io/Portifolio/";
#endif
builder.Services.AddMudServices();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseElement) });

await builder.Build().RunAsync();
