using MachsystemsTask.Entity;

namespace MachsystemsTask.Services
{
    public interface IOrderItemsService
    {
        Task<List<OrderItems>> GetItemsForOrderAsync(int OrderId);

        Task<OrderItems?> GetOrderItemsAsync(int OrderId, string ItemName);

        Task AddOrderItemsAsync(int OrderId, string ItemName, int Count);

        Task DeleteOrderItemsAsync(int OrderId, string ItemName);
    }
}
