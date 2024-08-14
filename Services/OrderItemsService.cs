using MachsystemsTask.Data;
using MachsystemsTask.Entity;
using Microsoft.EntityFrameworkCore;

namespace MachsystemsTask.Services;

public class OrderItemsService : IOrderItemsService
{
    private readonly ApplicationDbContext _context;

    public OrderItemsService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<OrderItems>> GetItemsForOrderAsync(int OrderId)
    {
        return await _context.OrderItems.Where(oi => oi.OrderId == OrderId).ToListAsync();
    }

    public async Task<OrderItems> GetOrderItemAsync(int OrderId, string ItemName)
    {
        return await _context.OrderItems.FindAsync(OrderId, ItemName);
    }

    public async Task AddOrderItemsAsync(int OrderId, OrderItems item)
    {
        _context.OrderItems.Add(item);

        await _context.SaveChangesAsync();
    }

    public async Task UpdateOrderItemsAsync(int OrderId, OrderItems item)
    {
        var DbOrderItems = await _context.OrderItems.FindAsync(OrderId, item.ItemName);

        if (DbOrderItems != null)
        {
            DbOrderItems.Order = item.Order;
            DbOrderItems.OrderId = OrderId;
            DbOrderItems.ItemName = item.ItemName;
            DbOrderItems.ItemCount = item.ItemCount;

            await _context.SaveChangesAsync();
        }
    }

    public async Task DeleteOrderItemsAsync(int OrderId, string ItemName)
    {
        var DbOrderItems = await _context.OrderItems.FindAsync(OrderId, ItemName);

        if (DbOrderItems != null)
        {
            _context.OrderItems.Remove(DbOrderItems);

            await _context.SaveChangesAsync();
        }
    }
}
