﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebsite.Shared.Models.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        // ДОБАВЬ ЭТУ СТРОКУ:
        public DateTime? BookingDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
