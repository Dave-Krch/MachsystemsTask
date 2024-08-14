using MachsystemsTask.Data;
using MachsystemsTask.Entity;
using Microsoft.EntityFrameworkCore;

namespace MachsystemsTask.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int Id)
        {
            return await _context.Orders.FindAsync(Id);
        }

        public async Task AddOrderAsync(Order order)
        {
            _context.Orders.Add(order);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            var DbOrder = await _context.Orders.FindAsync(order.Id);

            if (DbOrder != null)
            {
                DbOrder.Created = order.Created;
                DbOrder.CustomerId = order.CustomerId;
                DbOrder.Customer = order.Customer;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteOrderAsync(int Id)
        {
            var DbOrder = await _context.Orders.FindAsync(Id);

            if (DbOrder != null)
            {
                _context.Orders.Remove(DbOrder);

                await _context.SaveChangesAsync();
            }
        }
    }
}
