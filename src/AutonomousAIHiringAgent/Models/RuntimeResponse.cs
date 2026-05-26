namespace AutonomousAIHiringAgent.Models;

/// <summary>
/// Final autonomous runtime response.
/// </summary>
public class RuntimeResponse
{
    public string Planner { get; set; } = string.Empty;

    public List<string> Skills { get; set; } = new();

    public string Execution { get; set; } = string.Empty;

    public string Reflection { get; set; } = string.Empty;

    public string Memory { get; set; } = string.Empty;
}