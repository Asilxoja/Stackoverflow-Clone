using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        [Required, StringLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(50)]
        public string? LastName { get; set; }

        public List<Saved> Saves { get; set; } = new();
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();
        public ICollection<Saved> Saveds { get; set; } = new List<Saved>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}