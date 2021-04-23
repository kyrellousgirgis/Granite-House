using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace final_MVC_Test.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Display(Name = "Sales Person")]
        public string SalesPersonId { get; set; }

        [ForeignKey("SalesPersonId")]
        public virtual ApplicationUser SalesPerson { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime AppointmentDate { get; set; }

        [NotMapped]
        [Required]
        public DateTime AppointmentTime { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required]
        public string CustomerPhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string CustomerEmail { get; set; }

        public bool isConfirmed { get; set; }
    }
}
