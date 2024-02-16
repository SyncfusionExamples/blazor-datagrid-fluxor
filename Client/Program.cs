using Fluxor;
using FluxorSyncfusionGrid.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FluxorSyncfusionGrid.Client.Services;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<OrderService>();
// Add Fluxor
builder.Services.AddFluxor(options =>
{
    //options.ScanAssemblies(Assembly.GetExecutingAssembly());
    options.ScanAssemblies(typeof(Program).Assembly);
    options.UseReduxDevTools();
});
builder.Services.AddSyncfusionBlazor(e=> e.IgnoreScriptIsolation = false);
await builder.Build().RunAsync();
