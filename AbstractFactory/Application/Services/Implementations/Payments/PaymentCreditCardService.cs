using AbstractFactory.Application.Models.Orders;
using AbstractFactory.Core.Services.Interfaces;

namespace AbstractFactory.Application.Services.Implementations.Payments;

public class PaymentCreditCardService : IPaymentService
{
    public object Process(OrderModel model)
    {
        return "Transação aprovada";
    }
}