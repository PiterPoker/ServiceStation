using System;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Models.Entity
{
    public class Order
    {
        public Order()
        {
            Status = Status.InProgress;
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }

        [Required]
        [Display(Name = "Date order")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Order amount")]
        public decimal OrderAmount { get; set; }
        public Status Status { get; set; }
        public Client Client { get; set; }
        public Car Car { get; set; }
    }
}