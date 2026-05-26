using AutonomousAIHiringAgent.Interfaces;

namespace AutonomousAIHiringAgent.Executors;

/// <summary>
/// Executes runtime actions.
/// </summary>
public class ExecutionEngine : IExecutionEngine
{
    public string Execute(List<string> skills)
    {
        if (skills.Contains("SemanticSearchSkill"))
        {
            return "3 candidates retrieved and ranked";
        }

        return "Execution completed";
    }
}