using Microsoft.EntityFrameworkCore;
using NickiEatsOrderService.Domain.Entities;

namespace NickiEatsOrderService.Infrastructure.Data;

public class OrderDbContext(DbContextOptions<OrderDbContext> options) : DbContext(options)
{
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
}