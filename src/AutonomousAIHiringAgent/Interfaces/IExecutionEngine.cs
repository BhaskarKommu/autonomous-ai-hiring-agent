namespace AutonomousAIHiringAgent.Interfaces;

/// <summary>
/// Execution engine contract.
/// </summary>
public interface IExecutionEngine
{
    string Execute(List<string> skills);
}