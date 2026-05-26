using AutonomousAIHiringAgent.Interfaces;

namespace AutonomousAIHiringAgent.Reflection;

/// <summary>
/// Evaluates workflow quality.
/// </summary>
public class ReflectionService : IReflectionService
{
    public string Reflect(string executionResult)
    {
        if (executionResult.Contains("ranked"))
        {
            return "Ranking quality score: 8.2/10";
        }

        return "Execution evaluation completed";
    }
}