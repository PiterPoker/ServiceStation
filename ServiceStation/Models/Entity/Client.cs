using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiceStation.Models.Entity
{
    public class Client
    {
        public Client()
        {
            Order = new List<Order>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [RegularExpression(@"^([\+]?)((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,12}",
            ErrorMessage = "Не корректно введен номер телефона")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        public List<Order> Order { get; set; }
    }
}