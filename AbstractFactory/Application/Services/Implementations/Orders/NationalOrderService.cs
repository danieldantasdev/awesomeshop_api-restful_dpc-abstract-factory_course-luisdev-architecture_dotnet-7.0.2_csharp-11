using AbstractFactory.Application.Models.Orders;
using AbstractFactory.Core.Services.Interfaces;

namespace AbstractFactory.Application.Services.Implementations.Orders;

public class NationalOrderService : IOrderService
{
    public void Deliver(OrderModel orderModel)
    {
        throw new NotImplementedException();
    }
}