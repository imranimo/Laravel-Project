using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public class User
    {
        
        public int Userid { get; set; }

        [Required(ErrorMessage="UserName is Required and Should Unique")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(4,ErrorMessage="Password Should be at least 4 Character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Select Gender is Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddressAttribute(ErrorMessage="Enter a valid Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone No is Required")]
        [MaxLength(11,ErrorMessage="Max length is 11 which You are Crossing")]
        [MinLength(11,ErrorMessage="Minimum Length is 11 which is required More")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Date Of Birth is Required")]
        [Column(TypeName="Date")]
        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

        [Required]
        public string UserType { get; set; }

        [Required]
        public string Status { get; set; }
        

    }

}
