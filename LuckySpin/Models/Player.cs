using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player
    {
        //TODO: Annotate both Player properties as shown in the exercise Figure 1 and the resources section.
        [Required]
        [Display(Name = "Enter First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Enter Lucky Number")]
        public int Luck { get; set; }
    }
}