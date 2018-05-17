using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcourierRepository
{
    public class DelevaryInfo
    {
        public int DId { get; set; }

        [Required(ErrorMessage = "Pick Up city is Required")]
        public string PickUpCity { get; set; }

        [Required(ErrorMessage = "Pick Up Address is Required")]
        public string PickUpAddress { get; set; }

        [Required(ErrorMessage = "Delevary City is Required")]
        public string DelevaryCity { get; set; }

        [Required(ErrorMessage = "Delevary Address is Required")]
        public string DelevaryAddress { get; set; }

        [Required(ErrorMessage = "Delevary Status is Required")]
        public string DelevaryStatus { get; set; }

        [Required(ErrorMessage = "Category is Required")]
        public string Pcategory { get; set; }

        [Required(ErrorMessage = "Weight is Required")]
        public string weight { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public int price { get; set; }
    }
}
