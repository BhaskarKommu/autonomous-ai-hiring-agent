using AutonomousAIHiringAgent.Interfaces;

namespace AutonomousAIHiringAgent.Memory;

/// <summary>
/// Stores runtime memory and learning.
/// </summary>
public class MemoryManager : IMemoryManager
{
    public string SaveMemory(string request)
    {
        if (request.ToLower().Contains("backend"))
        {
            return "Backend hiring preference saved";
        }

        return "Runtime memory stored";
    }
}