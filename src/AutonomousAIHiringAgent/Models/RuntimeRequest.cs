namespace AutonomousAIHiringAgent.Models;

/// <summary>
/// Incoming request sent to the autonomous AI runtime.
/// </summary>
public class RuntimeRequest
{
    /// <summary>
    /// User request/prompt.
    /// </summary>
    public string Request { get; set; } = string.Empty;
}