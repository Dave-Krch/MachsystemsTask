using System.ComponentModel.DataAnnotations;

namespace MachsystemsTask.Entity
{
    public class Order
    {
        public Order(DateTime Created, int CustomerId)
        {
            this.Created = Created;
            this.CustomerId = CustomerId;
        }

        public Order(int Id, DateTime Created, int CustomerId, Customer Customer)
            : this(Created, CustomerId)
        {
            this.Id = Id;
            this.Customer = Customer;
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public int CustomerId { get; set; }
        
        public Customer Customer { get; set; }
    }
}
