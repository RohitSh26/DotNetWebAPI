using System.ComponentModel.DataAnnotations;

namespace DotNetWebAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string Company { get; set; }
    }
}