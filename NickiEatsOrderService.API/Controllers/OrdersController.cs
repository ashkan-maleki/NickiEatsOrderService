using Microsoft.AspNetCore.Mvc;
using NickiEatsOrderService.Application.CommandHandlers;
using NickiEatsOrderService.Application.Commands;

namespace NickiEatsOrderService.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController(CreateOrderCommandHandler createOrderHandler) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
    {
        if (command == null)
            return BadRequest();

        // Generate order id if not provided
        if (command.OrderId == Guid.Empty)
            command.OrderId = Guid.NewGuid();

        await createOrderHandler.Handle(command);
        return Ok(new { orderId = command.OrderId });
    }
}