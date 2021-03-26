using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserAlumniSena.Models
{
    public class UserRegClass
    {
        public int Usr_id { get; set; }

        [Display(Name = "User id number")]
        [Required(ErrorMessage = "Please enter your id number")]
        public string Usr_doc { get; set; }

        [Display(Name = "User document category")]
        [Required(ErrorMessage = "Please enter your id category")]
        public string Usr_kind_doc { get; set; }

        [Display(Name = "User name")]
        [Required(ErrorMessage = "Please enter user name")]
        public string Usr_name { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Usr_phonenum { get; set; }

        [Display(Name = "User name")]
        [Required(ErrorMessage = "Please enter user name")]
        public string Usr_email { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Please enter your gender")]
        public char Usr_gender { get; set; }

        [Display(Name = "Student's status")]
        [Required(ErrorMessage = "Please enter your student's status")]
        public string Usr_category { get; set; }

        [Display(Name = "Program")]
        [Required(ErrorMessage = "Please enter your program")]
        public string Usr_program { get; set; }

        [Display(Name = "Date Registration")]
        [Required(ErrorMessage = "Please enter Date Registration")]
        public DateTime Usr_startdate { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter your address")]
        public string Usr_address { get; set; }

        [Display(Name = "Neighborhood")]
        [Required(ErrorMessage = "Please enter your neighborhood")]
        public string Usr_neighborhood { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter your city")]
        public string Usr_city { get; set; }

        [Display(Name = "Province")]
        [Required(ErrorMessage = "Please enter yoour province")]
        public string Usr_province { get; set; }

        [Display(Name = "Date registration at Sena")]
        [Required(ErrorMessage = "Please enter Date registration at Sena")]
        public DateTime Usr_dateregistr { get; set; }
    }
}
