﻿using System.ComponentModel.DataAnnotations;

namespace MachsystemsTask.Entity
{
    public class OrderItems
    {
        public OrderItems(int OrderId, Order Order, string ItemName, int ItemCount)
        {
            this.OrderId = OrderId;
            this.Order = Order;
            this.ItemName = ItemName;
            this.ItemCount = ItemCount;
        }

        public OrderItems(int OrderId, string ItemName, int ItemCount)
        {
            this.OrderId = OrderId;
            this.ItemName = ItemName;
            this.ItemCount = ItemCount;
        }

        [Required]
        public int OrderId { get; set; }
        
        public Order Order { get; set; }

        [Required]
        public string ItemName { get; set; }
        [Required]
        public int ItemCount { get; set; }
    }
}
