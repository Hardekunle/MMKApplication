using System.ComponentModel.DataAnnotations;

namespace TestAPI.Models.ClientModels
{
    public class SMSDTO
    {
        [Required]
        [MinLength(6,ErrorMessage ="")]
        [MaxLength(16,ErrorMessage ="")]
        public string From { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "")]
        [MaxLength(16, ErrorMessage = "")]
        public string To { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "")]
        [MaxLength(16, ErrorMessage = "")]
        public string Text { get; set; }

    }
}
