using MachsystemsTask.Entity;

namespace MachsystemsTask.Services
{
    public interface IOrderItemsService
    {
        Task<List<OrderItems>> GetItemsForOrderAsync(int OrderId);

        Task AddOrderItemsAsync(int OrderId, string ItemName, int Count);

        Task DeleteOrderItemsAsync(int OrderId, string ItemName);
    }
}
