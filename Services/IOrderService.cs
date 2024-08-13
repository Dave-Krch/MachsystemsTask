using MachsystemsTask.Data;

namespace MachsystemsTask.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersAsync();

        Task<Order> GetOrderByIdAsync(int Id);

        Task AddOrderAsync(Order order);

        Task UpdateOrderAsync(Order order);

        Task DeleteOrderAsync(int Id);
    }
}
