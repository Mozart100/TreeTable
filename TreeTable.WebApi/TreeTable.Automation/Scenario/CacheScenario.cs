using Microsoft.Extensions.Logging;
using TreeTable.Automation.Scenario;

namespace Chato.Automation.Scenario;

internal class CacheScenario : ScenarioBase
{

    public CacheScenario(ILogger<BasicScenario> logger, ScenarioConfig config) : base(logger, config)
    {

        SetupsLogicCallback.Add(GetConfigurations_Step);

        BusinessLogicCallbacks.Add(Setup_SendingInsideTheRoom_Step);
        BusinessLogicCallbacks.Add(UnusedCache_Preloning);


    }

    private async Task GetConfigurations_Step()
    {
    }

    public override string ScenarioName => "Only Persistent cache remains.";
    public override string Description => "All cache except persistent removed.";


    private async Task UnusedCache_Preloning()
    {

    }

    private async Task UnusedCacheEvicted()
    {


    }

    private async Task AbsoluteEviction()
    {
    }


    private async Task Setup_SendingInsideTheRoom_Step()
    {
    }


}
