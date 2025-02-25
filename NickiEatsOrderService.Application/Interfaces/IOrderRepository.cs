using NickiEatsOrderService.Domain.Entities;

namespace NickiEatsOrderService.Application.Interfaces;

public interface IOrderRepository
{
    Task AddAsync(Order order);
}