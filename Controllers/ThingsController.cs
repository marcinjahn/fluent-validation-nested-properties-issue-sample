using Microsoft.AspNetCore.Mvc;

namespace fluentnestedtest.Controllers;

[ApiController]
[Route("[controller]")]
public class ThingsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ThingsController> _logger;

    public ThingsController(ILogger<ThingsController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public Task Create(Thing thing)
    {
        _logger.LogInformation("New request...");
        // do something with thing...;
        return Task.CompletedTask;
    }
}
