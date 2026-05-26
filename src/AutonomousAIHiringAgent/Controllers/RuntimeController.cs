using AutonomousAIHiringAgent.Executors;
using AutonomousAIHiringAgent.Memory;
using AutonomousAIHiringAgent.Models;
using AutonomousAIHiringAgent.Planner;
using AutonomousAIHiringAgent.Reflection;
using AutonomousAIHiringAgent.Skills;
using Microsoft.AspNetCore.Mvc;

namespace AutonomousAIHiringAgent.Controllers;

/// <summary>
/// Main autonomous AI runtime controller.
/// </summary>
[ApiController]
[Route("api/runtime")]
public class RuntimeController : ControllerBase
{
    /// <summary>
    /// Execute autonomous runtime workflow.
    /// </summary>
    [HttpPost("execute")]
    public ActionResult<RuntimeResponse> Execute(RuntimeRequest request)
    {
        // Step 1: Analyze intent.
        var planner = new PlannerService();
        var plannerResult = planner.AnalyzeIntent(request.Request);

        // Step 2: Select skills.
        var skillEngine = new SkillEngine();
        var skills = skillEngine.SelectSkills(plannerResult);

        // Step 3: Execute workflow.
        var executionEngine = new ExecutionEngine();
        var executionResult = executionEngine.Execute(skills);

        // Step 4: Reflect on execution quality.
        var reflectionService = new ReflectionService();
        var reflectionResult = reflectionService.Reflect(executionResult);

        // Step 5: Save memory.
        var memoryManager = new MemoryManager();
        var memoryResult = memoryManager.SaveMemory(request.Request);

        // Final runtime response.
        return Ok(new RuntimeResponse
        {
            Planner = plannerResult,
            Skills = skills,
            Execution = executionResult,
            Reflection = reflectionResult,
            Memory = memoryResult
        });
    }
}