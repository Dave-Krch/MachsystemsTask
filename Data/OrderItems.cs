using System.ComponentModel.DataAnnotations;

namespace MachsystemsTask.Data
{
    public class OrderItems
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public string ItemName { get; set; }
        public int ItemCount{ get; set; }
    }
}
