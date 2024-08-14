using System.ComponentModel.DataAnnotations;

namespace MachsystemsTask.Entity
{
    public class OrderItems
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public Order Order { get; set; }

        [Required]
        public string ItemName { get; set; }
        [Required]
        public int ItemCount { get; set; }
    }
}
