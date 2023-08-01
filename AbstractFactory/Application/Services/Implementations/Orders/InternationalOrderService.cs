using AbstractFactory.Application.Models.Orders;
using AbstractFactory.Core.Services.Interfaces;

namespace AbstractFactory.Application.Services.Implementations.Orders;

public class InternationalOrderService : IOrderService
{
    public void Deliver(OrderModel orderModel)
    {
        throw new NotImplementedException();
    }
}