using AbstractFactory.Core.Enums;

namespace AbstractFactory.Core.Services.Interfaces;

public interface IOrderAbstractFactory
{
    IPaymentService GetPaymentService(PaymentMethod paymentMethod);
    IOrderService GetDeliveryService();
}