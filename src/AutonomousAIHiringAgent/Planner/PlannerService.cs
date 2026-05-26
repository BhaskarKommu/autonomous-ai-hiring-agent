namespace AutonomousAIHiringAgent.Planner;

/// <summary>
/// Responsible for analyzing user intent
/// and selecting runtime workflows.
/// </summary>
public class PlannerService
{
    /// <summary>
    /// Analyze user request.
    /// </summary>
    public string AnalyzeIntent(string request)
    {
        // Simple MVP logic.
        // Later this can become AI-powered.

        if (request.ToLower().Contains("engineer"))
        {
            return "Hiring workflow detected";
        }

        return "General workflow detected";
    }
}