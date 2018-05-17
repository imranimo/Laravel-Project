using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public class Office
    {
        public int OfficeId { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Employee Name is Required")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Post-Man name is Required")]
        [Display(Name = "Post-Man Name")]
        public string PostmanName { get; set; }

        [Required(ErrorMessage = "Contact No is Required")]
        [MaxLength(11, ErrorMessage = "Max length is 11 which You are Crossing")]
        [MinLength(11, ErrorMessage = "Minimum Length is 11 which is required More")]
        [Display(Name = "Contact No")]
        public int ContactNo { get; set; }
    }
}
