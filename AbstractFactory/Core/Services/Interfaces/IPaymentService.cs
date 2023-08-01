using AbstractFactory.Application.Models.Orders;

namespace AbstractFactory.Core.Services.Interfaces;

public interface IPaymentService
{
    object Process(OrderModel model);
}