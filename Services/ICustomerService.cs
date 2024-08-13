using MachsystemsTask.Data;

namespace MachsystemsTask.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomersAsync();
        
        Task<Customer> GetCustomerByIdAsync(int id);

        Task AddCustomerAsync(Customer customer);

        Task UpdateCustomerAsync(int id, string Name, string Email, int Age, string City, string Country);

        Task DeleteCustomerAsync(int id);
       
    }
}
        
