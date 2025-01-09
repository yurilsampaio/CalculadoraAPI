using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class CalculadoraController : ControllerBase
{
    [HttpGet("somar")]
    public IActionResult Somar(double n1, double n2)
    {
        return Ok(n1 + n2);
    }

    [HttpGet("subtrair")]
    public IActionResult Subtrair(double n1, double n2)
    {
        return Ok(n1 - n2);
    }

    [HttpGet("multiplicar")]
    public IActionResult Multiplicar(double n1, double n2)
    {
        return Ok(n1 * n2);
    }

    [HttpGet("dividir")]
    public IActionResult Dividir(double n1, double n2)
    {
        if (n2 == 0)
        {
            return BadRequest("Não é possível dividir por zero.");
        }

        return Ok(n1 / n2);
    }
}