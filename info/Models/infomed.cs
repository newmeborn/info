using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace info.Models
{
    public class infomed
    {
        [Key]
        public int Id { get; set; }

       
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "last Name ")]
        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength: 20)]
        public string BrandName { get; set; }

        [Display(Name = "On going Medicines")]
        [Required(ErrorMessage = "Required")]
        public string illness { get; set; }


        [Display(Name = "Age")]
        [Required(ErrorMessage = "Required")]
        public int sales { get; set; }

        [Display(Name = "Appointment ID")]
        [Required(ErrorMessage = "Required")]
        public int stock { get; set; }



        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public DateTime Expiry { get; set; }


        [Display(Name = "Any other issue")]
        public string medicinetype { get; set; }
        public int DisplayOrder { get; internal set; }
    }


 
        public class LoginViewModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            public bool RememberMe { get; set; }
        }
    }

