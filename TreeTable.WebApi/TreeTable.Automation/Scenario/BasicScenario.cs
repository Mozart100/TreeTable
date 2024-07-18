using Microsoft.Extensions.Logging;
using TreeTable.Automation.Scenario;

namespace Chato.Automation.Scenario;

internal class BasicScenario : ScenarioBase
{
    private const string First_Group = "haifa";

    private const string Anatoliy_User = "anatoliy";
    private const string Olessya_User = "olessya";
    private const string Nathan_User = "nathan";


    private const string Natali_User = "natali";
    private const string Max_User = "max";
    private const string Idan_User = "itan";

    public BasicScenario(ILogger<BasicScenario> logger, ScenarioConfig config) : base(logger, config)
    {

        BusinessLogicCallbacks.Add(SetupGroup);
        BusinessLogicCallbacks.Add(SendingToSpecificPerson);

    }

    private async Task CheckAllCleaned()
    {
    }

    public override string ScenarioName => "All sort of mini scenarios";

    public override string Description => "To run mini scenarios.";

    private async Task SendingToSpecificPerson()
    {

    }

    private async Task VerificationStep()
    {

    }


    private async Task SendingOnlyToRoomStep()
    {
    }


    private async Task SetupGroup()
    {
    }

    private async Task Setup_SendingOnlyToRoomStep_Step()
    {
    }

}
