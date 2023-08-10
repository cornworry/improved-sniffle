using Microsoft.AspNetCore.Mvc;

namespace Dotnet.Docker.DiceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DiceController : ControllerBase
{
    private readonly ILogger<DiceController> _logger;

    public DiceController(ILogger<DiceController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Roll")]
    public RollResult Get(int times, int size)
    {
        return new RollResult { Result = 999 };
    }
}
