using System.ComponentModel.DataAnnotations;

namespace MachsystemsTask.Entity
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]

        public int CustomerId { get; set; }
        [Required]
        public Customer Customer { get; set; }
    }
}
