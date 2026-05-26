namespace AutonomousAIHiringAgent.Skills;

/// <summary>
/// Selects reusable runtime skills.
/// </summary>
public class SkillEngine
{
    /// <summary>
    /// Select skills based on planner result.
    /// </summary>
    public List<string> SelectSkills(string plannerResult)
    {
        var skills = new List<string>();

        if (plannerResult.Contains("Hiring"))
        {
            skills.Add("SemanticSearchSkill");
            skills.Add("CandidateRankingSkill");
        }

        return skills;
    }
}