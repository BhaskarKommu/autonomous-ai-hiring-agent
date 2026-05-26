namespace AutonomousAIHiringAgent.Memory;

/// <summary>
/// Stores runtime learning and preferences.
/// </summary>
public class MemoryManager
{
    /// <summary>
    /// Simulated memory persistence.
    /// </summary>
    public string SaveMemory(string request)
    {
        if (request.ToLower().Contains("backend"))
        {
            return "Backend hiring preference saved";
        }

        return "Runtime memory stored";
    }
}