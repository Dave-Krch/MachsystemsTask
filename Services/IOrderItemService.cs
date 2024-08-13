using MachsystemsTask.Data;

namespace MachsystemsTask.Services
{
    public interface IOrderItemService
    {
        Task<List<OrderItems>> GetItemsForOrderAsync(int OrderId);
        Task<OrderItems> GetOrderItem(int OrderId, string Item);
        Task EditItemsFromOrderAsync(int OrderId, string Item, int ItemCount);

        Task RemoveItemsFromOrderAsync(int OrderId, string Item, int ItemCount);
    }
}
