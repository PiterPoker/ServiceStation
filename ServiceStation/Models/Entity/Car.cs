using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace ServiceStation.Models.Entity
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Make")]
        public string Make { get; set; }
        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Required]
        [Display(Name = "Year")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "Длина строки должна быть от 3 до 7 символов")]
        [Display(Name = "VIN")]
        public string Vin { get; set; }
        public List<Order> Order { get; set; }

        public Car()
        {
            Order = new List<Order>();
        }
    }
}