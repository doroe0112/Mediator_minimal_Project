using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorTest10.Controllers;


[ApiController]
[Route("api/[controller]")]
public abstract class BaseController : ControllerBase
{
    private IMediator _mediator;
    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
}