using AbstractFactory.Core.Enums;

namespace AbstractFactory.Core.Services.Interfaces;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(PaymentMethod paymentMethod);
}