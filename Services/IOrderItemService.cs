using MachsystemsTask.Entity;

namespace MachsystemsTask.Services
{
    public interface IOrderItemService
    {
        Task<List<OrderItems>> GetItemsForOrderAsync(int OrderId);

        Task<OrderItems> GetOrderItemAsync(int OrderId, string ItemName);
        
        Task AddOrderItemsAsync(int OrderId, OrderItems item);

        Task UpdateOrderItemsAsync(int OrderId, OrderItems item);

        Task DeleteOrderItemsAsync(int OrderId, string ItemName);
    }
}
