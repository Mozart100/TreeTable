﻿using Chato.Automation;
using Chato.Automation.Scenario;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TreeTable.Automation.Scenario;

using IHost host = CreateHostBuilder(args).Build();
using var scop = host.Services.CreateScope();
var services = scop.ServiceProvider;

try
{
    var app = services.GetRequiredService<App>();
    await app.RunAsync(null);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



static IHostBuilder CreateHostBuilder(string[] args)
{
    var config = new ScenarioConfig
    {
        BaseUrl = "https://localhost:7138"
    };

    return Host.CreateDefaultBuilder(args)
        .ConfigureLogging(logging =>
        {
            //logging.AddFilter("Microsoft.AspNetCore.SignalR", LogLevel.Trace);
            //logging.AddFilter("Microsoft.AspNetCore.Http.Connections", LogLevel.Trace);
        })

        .ConfigureServices((_, services) =>
    {
        services.AddSingleton<App>();
        services.AddSingleton<ScenarioConfig>(config);
        services.AddSingleton<BasicScenario>();
        services.AddSingleton<CacheScenario>();

        





    });
}



