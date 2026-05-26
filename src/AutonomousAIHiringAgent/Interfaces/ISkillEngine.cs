namespace AutonomousAIHiringAgent.Interfaces;

/// <summary>
/// Skill engine contract.
/// </summary>
public interface ISkillEngine
{
    List<string> SelectSkills(string plannerResult);
}