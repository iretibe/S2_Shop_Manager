using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using S2_Shop_Manager.Web.Client;
using S2_Shop_Manager.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IEmployeeRepository, ClientEmployeeService>();

//builder.Services.AddBlazor().AddCircuitOptions(options =>
//{
//    options.DetailedErrors = true;
//});

await builder.Build().RunAsync();
