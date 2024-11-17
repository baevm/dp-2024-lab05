using EshopPattern.Commands;

namespace EshopPattern.Handlers;

/// <summary>
/// Отвечает за обработку платежа
/// </summary>
class PaymentProcessHandler : OrderHandlerBase
{
    public PaymentProcessHandler() : base(new ProcessPaymentCommand())
    {
    }
}