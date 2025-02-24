using NickiEatsOrderService.Domain.Enums;

namespace NickiEatsOrderService.Domain.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public DateTime OrderDate { get; private set; }
    public List<OrderItem> Items { get; private set; } = new List<OrderItem>();
    public Payment Payment { get; private set; }
    public OrderStatus Status { get; private set; }

    public Order(Guid id, DateTime orderDate)
    {
        Id = id;
        OrderDate = orderDate;
        Status = OrderStatus.Created;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public void SetPayment(Payment payment)
    {
        Payment = payment;
    }

    public void MarkAsCompleted()
    {
        Status = OrderStatus.Completed;
    }
}





