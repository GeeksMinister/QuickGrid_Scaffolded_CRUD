using QuickGrid_Scaffolded_CRUD.Helpers;
using System.ComponentModel;

namespace QuickGrid_Scaffolded_CRUD.Models;

public class Customer
{
    [Key]
    [StringLength(36)]
    public string ID { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [DisplayName("First Name")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name should be between 3 - 50 characters")]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [DisplayName("Last Name")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name should be between 3 - 50 characters")]
    public string LastName { get; set; } = string.Empty;

    [DisplayName("Date of Birth")]
    [Required]
    [ValidAge]
    public DateTime Birthdate { get; set; } = DateTime.Now.AddYears(-18);

    [StringLength(20, ErrorMessage = "number is too big. Check your input!")]
    [Phone]
    [Range(0, long.MaxValue, ErrorMessage = "Contact number should not contain characters")]
    public string Phone { get; set; } = string.Empty;

    [EmailAddress]
    [StringLength(300, ErrorMessage = "Email is too big. 300 characters Max!")]
    public string Email { get; set; } = string.Empty;

    public string Username() => FirstName + ' ' + LastName;

    public Customer()
    {

    }
}
