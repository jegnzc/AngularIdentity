using Duende.Bff;
using JavaScriptClient.Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JavaScriptClient.Controllers;

[Authorize]
[Route("test")]
public class IdentityController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public IdentityController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
    }
}