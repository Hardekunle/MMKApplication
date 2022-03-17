using System.ComponentModel.DataAnnotations;

namespace TestAPI.Models.ClientModels
{
    public class SMSDTO
    {

        [Required(ErrorMessage = "from is missing")]
        [MinLength(6, ErrorMessage = "from is invalid")]
        [MaxLength(16, ErrorMessage = "from is invalid")]
        public string From { get; set; }

        [Required(ErrorMessage = "to is missing")]
        [MinLength(6, ErrorMessage = "to is invalid")]
        [MaxLength(16, ErrorMessage = "to is invalid")]
        public string To { get; set; }

        [Required(ErrorMessage ="text is missing")]
        [MinLength(1, ErrorMessage = "text is invalid")]
        [MaxLength(120, ErrorMessage = "text is invalid")]
        public string Text { get; set; }

    }
}
