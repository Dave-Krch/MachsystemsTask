﻿using MachsystemsTask.Data;

namespace MachsystemsTask.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomersAsync();
        
        Task<Customer> GetCustomerByIdAsync(int id);

        Task AddCustomerAsync(Customer customer);

        Task UpdateCustomerAsync(Customer customer);

        Task DeleteCustomerAsync(int id);
       
    }
}
        
