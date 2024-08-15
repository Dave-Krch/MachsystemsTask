using MachsystemsTask.Data;
using MachsystemsTask.Entity;
using Microsoft.EntityFrameworkCore;
using static MudBlazor.CategoryTypes;

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

    public async Task AddOrderItemsAsync(int OrderId, string ItemName, int Count)
    {
        var DbItem = await _context.OrderItems.FindAsync(OrderId, ItemName);

        if (DbItem == null)
        {
            _context.OrderItems.Add(new OrderItems(OrderId, ItemName, Count));
        }
        else
        {
            if(DbItem.ItemCount + Count > 0)
            {
                DbItem.ItemCount += Count;
            }
            else
            {
                DbItem.ItemCount = 0;
            }
        }


        await _context.SaveChangesAsync();
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
