using System.ComponentModel.DataAnnotations;

namespace EAD_CA_PROJECT_INVEST.Model
{
    public enum UserType 
    { 
        [Display(Name ="Basic user")]
        basic,
        [Display(Name = "Admin user")]
        admin 
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name field is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="User Type Required")]
        public UserType UserType { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="Email required")]
        public  string Email { get; set; }
    }
}
