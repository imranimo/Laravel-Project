using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public class Product
    {
        public int PId { get; set; }

        [Required(ErrorMessage = "Category is Required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Weight Range is Required")]
        [Display(Name = "Weight Range")]
        public string WeightRange { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public int Price { get; set; }
    }
}