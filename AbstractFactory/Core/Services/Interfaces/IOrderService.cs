using AbstractFactory.Application.Models.Orders;

namespace AbstractFactory.Core.Services.Interfaces;

public interface IOrderService
{
    void Deliver(OrderModel orderModel);
}