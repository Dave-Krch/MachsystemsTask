using MachsystemsTask.Data;
using MachsystemsTask.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MachsystemsTask.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomersAsync() {
            return await _context.Customers.ToListAsync();
        }

        public async Task AddCustomerAsync(Customer customer) {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(int Id)
        {
            return await _context.Customers.FindAsync(Id);
        }

        public async Task UpdateCustomerAsync(int Id, string Name, string Email, int Age, string City, string Country) {
            var customer = await _context.Customers.FindAsync(Id);
            if (customer != null)
            {
                customer.Name = Name;
                customer.Email = Email;
                customer.Age = Age;
                customer.City = City;
                customer.Country = Country;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCustomerAsync(int Id) {
            var customer = await _context.Customers.FindAsync(Id);
            if (customer != null) {
                _context.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }   
  
    }
}
