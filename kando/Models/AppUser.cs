using System.ComponentModel.DataAnnotations;

namespace kando.Models;

public class AppUser
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required(ErrorMessage = "Name is required")]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}