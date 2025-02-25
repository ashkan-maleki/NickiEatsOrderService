namespace NickiEatsOrderService.Application.Commands;

public class CreateOrderCommand
{
    public Guid OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public List<CreateOrderItemDto> Items { get; set; }
}

public class CreateOrderItemDto
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}