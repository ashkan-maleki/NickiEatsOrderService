using NickiEatsOrderService.Domain.Enums;

namespace NickiEatsOrderService.Domain.Entities;

public class Payment
{
    public Guid Id { get; private set; }
    public decimal Amount { get; private set; }
    public PaymentStatus Status { get; private set; }
    public DateTime? PaymentDate { get; private set; }

    public Payment(Guid id, decimal amount)
    {
        Id = id;
        Amount = amount;
        Status = PaymentStatus.Pending;
    }

    public void CompletePayment()
    {
        Status = PaymentStatus.Completed;
        PaymentDate = DateTime.UtcNow;
    }
}