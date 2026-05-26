namespace AutonomousAIHiringAgent.Interfaces;

/// <summary>
/// Planner service contract.
/// </summary>
public interface IPlannerService
{
    /// <summary>
    /// Analyze user intent.
    /// </summary>
    string AnalyzeIntent(string request);
}