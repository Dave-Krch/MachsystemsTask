using MachsystemsTask.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MachsystemsTask.Service
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomersAsync();
    }

    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomersAsync() {
            return await _context.Customers.ToListAsync();
        }

    }
}
