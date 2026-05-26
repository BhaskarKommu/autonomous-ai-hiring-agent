using AutonomousAIHiringAgent.Interfaces;
using AutonomousAIHiringAgent.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutonomousAIHiringAgent.Controllers;

/// <summary>
/// Main autonomous AI runtime controller.
/// </summary>
[ApiController]
[Route("api/runtime")]
public class RuntimeController : ControllerBase
{
    private readonly IPlannerService _planner;

    private readonly ISkillEngine _skillEngine;

    private readonly IExecutionEngine _executionEngine;

    private readonly IReflectionService _reflectionService;

    private readonly IMemoryManager _memoryManager;

    /// <summary>
    /// Constructor injection.
    /// ASP.NET Core automatically injects services.
    /// </summary>
    public RuntimeController(
        IPlannerService planner,
        ISkillEngine skillEngine,
        IExecutionEngine executionEngine,
        IReflectionService reflectionService,
        IMemoryManager memoryManager)
    {
        _planner = planner;

        _skillEngine = skillEngine;

        _executionEngine = executionEngine;

        _reflectionService = reflectionService;

        _memoryManager = memoryManager;
    }

    /// <summary>
    /// Execute autonomous runtime workflow.
    /// </summary>
    [HttpPost("execute")]
    public ActionResult<RuntimeResponse> Execute(RuntimeRequest request)
    {
        // Step 1: Analyze intent.
        var plannerResult = _planner.AnalyzeIntent(request.Request);

        // Step 2: Select runtime skills.
        var skills = _skillEngine.SelectSkills(plannerResult);

        // Step 3: Execute workflow.
        var executionResult = _executionEngine.Execute(skills);

        // Step 4: Reflect on execution quality.
        var reflectionResult = _reflectionService.Reflect(executionResult);

        // Step 5: Persist runtime memory.
        var memoryResult = _memoryManager.SaveMemory(request.Request);

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