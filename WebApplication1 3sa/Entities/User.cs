using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1_3sa_.Entities

{
    [Table("Users")]

    public class User
    {
        [Key]
        public Guid Id  { get; set; }

        [StringLength(50)]
        public string? NameSurname { get; set; } = null;

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        public bool Locked { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;



    }
}
