using System.ComponentModel.DataAnnotations;


namespace info.Models
{
    public class infomed
    {
        [Key]
        public int Id { get; set; }

       
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Brand name ")]
        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength: 20)]
        public string BrandName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string illness { get; set; }


        [Display(Name = "Sales")]
        [Required(ErrorMessage = "Required")]
        public int sales { get; set; }

        [Required(ErrorMessage = "Required")]
        public int stock { get; set; }



        [Display(Name = "Expiry date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public DateTime Expiry { get; set; }

        public string medicinetype { get; set; }
        public int DisplayOrder { get; internal set; }
    }
}
