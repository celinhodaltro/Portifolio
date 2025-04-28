using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PortifolioApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Aqui come�a o truque:
var baseElement = builder.HostEnvironment.BaseAddress;
#if !DEBUG
    baseElement = "https://celinhodaltro.github.io/Portifolio/";
#endif

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseElement) });

await builder.Build().RunAsync();
