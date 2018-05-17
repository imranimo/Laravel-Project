using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public class Employee
    {
        public int EId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string EName { get; set; }

        [Required(ErrorMessage = "Type is Required")]
        public string EType { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string ECity { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string EAddress { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string EGender { get; set; }

        [Required(ErrorMessage = "Contact No is Required")]
        [MaxLength(11,ErrorMessage="Max length is 11 which You are Crossing")]
        [MinLength(11,ErrorMessage="Minimum Length is 11 which is required More")]
        public int EContactNo { get; set; }

        [Required(ErrorMessage = "Date Of Birth is Required")]
        [Column(TypeName="Date")]
        [Display(Name = "Date of Birth")]
        public string EDob { get; set; }
        
        [EmailAddressAttribute(ErrorMessage="Enter a valid Email")]
        [DataType(DataType.EmailAddress)]
        public string EEmail { get; set; }

        [Required(ErrorMessage = "Status is Required")]
        public string Estatus { get; set; }
    }
}
