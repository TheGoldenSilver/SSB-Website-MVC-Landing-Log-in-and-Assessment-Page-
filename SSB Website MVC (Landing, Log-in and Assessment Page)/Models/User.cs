using System.ComponentModel.DataAnnotations;

namespace SkillSandbox.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
