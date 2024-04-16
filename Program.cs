using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WasmPortfolio;
using WasmPortfolio.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<ProjectServices>();
builder.Services.AddScoped<FooterServices>();
builder.Services.AddScoped<NavServices>();
builder.Services.AddScoped<EmailServices>();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
