using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Backend4.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "Firstname is required")]
        public String Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        public String Lastname { get; set; }


        public Int32 Month { get; set; }


        public Int32 Day { get; set; }


        public Int32 Year { get; set; }

        public String Gender { get; set; }

        public bool Exist { get; set; }
    }
}
