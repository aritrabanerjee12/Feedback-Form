using System.ComponentModel.DataAnnotations;

namespace ASPCoreWebAppWithAPI.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(1000)]
        public string FeedbackMessage { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5 stars.")]
        public int Rating { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime SubmittedOn { get; set; } = DateTime.Now;
    }
}
