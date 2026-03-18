using System.ComponentModel.DataAnnotations;

namespace MTenantSolution.Model.InputModel
{
    public class ApplicationUserLoginInputModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}
