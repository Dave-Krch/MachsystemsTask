﻿using MachsystemsTask.Data;
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

        public async Task UpdateCustomerAsync(Customer customer) {
            var DbCustomer = await _context.Customers.FindAsync(customer.Id);
            if (DbCustomer != null)
            {
                DbCustomer.Name = customer.Name;
                DbCustomer.Email = customer.Email;
                DbCustomer.Age = customer.Age;
                DbCustomer.City = customer.City;
                DbCustomer.Country = customer.Country;

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
