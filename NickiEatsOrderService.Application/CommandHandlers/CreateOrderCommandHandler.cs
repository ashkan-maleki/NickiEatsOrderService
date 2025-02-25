using NickiEatsOrderService.Application.Commands;
using NickiEatsOrderService.Application.Interfaces;
using NickiEatsOrderService.Domain.Entities;

namespace NickiEatsOrderService.Application.CommandHandlers;

public class CreateOrderCommandHandler(IOrderRepository orderRepository)
{
    public async Task Handle(CreateOrderCommand command)
    {
        // Create a new Order aggregate
        var order = new Order(command.OrderId, command.OrderDate);

        // Loop through each OrderItem DTO and add to the order
        foreach (var itemDto in command.Items)
        {
            var orderItem = new OrderItem(
                id: Guid.NewGuid(),
                productId: itemDto.ProductId,
                quantity: itemDto.Quantity,
                unitPrice: itemDto.UnitPrice);

            order.AddItem(orderItem);
        }

        // Persist the order using the repository
        await orderRepository.AddAsync(order);
    }
}