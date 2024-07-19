using Microsoft.AspNetCore.Mvc;

namespace Wpm.Clinic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultationController : ControllerBase
{
    [HttpPost("/start")]
    public async Task<IActionResult> Start(StartConsultationCommand command)
    {
        return Ok();
    }
}

public record StartConsultationCommand(int PatientId);