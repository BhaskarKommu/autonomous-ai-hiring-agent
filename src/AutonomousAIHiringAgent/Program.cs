using AutonomousAIHiringAgent.Executors;
using AutonomousAIHiringAgent.Interfaces;
using AutonomousAIHiringAgent.Memory;
using AutonomousAIHiringAgent.Planner;
using AutonomousAIHiringAgent.Reflection;
using AutonomousAIHiringAgent.Skills;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IPlannerService, PlannerService>();

builder.Services.AddScoped<ISkillEngine, SkillEngine>();

builder.Services.AddScoped<IExecutionEngine, ExecutionEngine>();

builder.Services.AddScoped<IReflectionService, ReflectionService>();

builder.Services.AddScoped<IMemoryManager, MemoryManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
