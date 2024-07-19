using Microsoft.AspNetCore.Mvc;
using Wpm.Clinic.Application;

namespace Wpm.Clinic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultationController(ClinicApplicationService applicationService) : ControllerBase
{
    [HttpPost("/start")]
    public async Task<IActionResult> Start(StartConsultationCommand command)
    {
        var result = await applicationService.Handle(command);
        return Ok(result);
    }
}

public record StartConsultationCommand(int PatientId);