using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player 
    {
        //TODO: Annotate both Player properties as shown in the exercise Figure 1 and the resources section.
        [Required]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
        public string FirstName { get; set; }

        [Range(1,10)]
        public int Luck { get; set; }
    }
}