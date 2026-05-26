using AutonomousAIHiringAgent.Interfaces;

namespace AutonomousAIHiringAgent.Planner;

/// <summary>
/// Responsible for analyzing user intent
/// and selecting workflows.
/// </summary>
public class PlannerService : IPlannerService
{
    /// <summary>
    /// Analyze incoming request.
    /// </summary>
    public string AnalyzeIntent(string request)
    {
        if (request.ToLower().Contains("engineer"))
        {
            return "Hiring workflow detected";
        }

        return "General workflow detected";
    }
}