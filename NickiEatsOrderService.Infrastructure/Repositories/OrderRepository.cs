using NickiEatsOrderService.Application.Interfaces;
using NickiEatsOrderService.Domain.Entities;
using NickiEatsOrderService.Infrastructure.Data;

namespace NickiEatsOrderService.Infrastructure.Repositories;

public class OrderRepository(OrderDbContext dbContext) : IOrderRepository
{
    public async Task AddAsync(Order order)
    {
        await dbContext.Orders.AddAsync(order);
        await dbContext.SaveChangesAsync();
    }
}