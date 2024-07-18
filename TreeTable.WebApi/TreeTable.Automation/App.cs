using Chato.Automation.Scenario;
using Microsoft.Extensions.Logging;

namespace Chato.Automation;

internal class App
{
    private readonly ILogger<App> _logger;
    private readonly BasicScenario _basicScenario;
    private readonly CacheScenario _cacheScenario;

    public App(ILogger<App> logger, 
        BasicScenario basicScenario,
        CacheScenario cacheScenario
        )
    {
        _logger = logger;
        this._basicScenario = basicScenario;
        this._cacheScenario = cacheScenario;
    }


    public async Task RunAsync(string[] args)
    {

        await _basicScenario.StartRunScenario();
        await _cacheScenario.StartRunScenario();


        Console.WriteLine("All test passed successfully!!!!!");
        Console.WriteLine("All test passed successfully!!!!!");
        Console.WriteLine("All test passed successfully!!!!!");
        Console.WriteLine("All test passed successfully!!!!!");
        Console.WriteLine("All test passed successfully!!!!!");
        Console.WriteLine("All test passed successfully!!!!!");


        Console.ReadLine();
    }
}
