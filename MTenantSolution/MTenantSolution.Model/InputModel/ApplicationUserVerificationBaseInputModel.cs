using System.ComponentModel.DataAnnotations;

namespace MTenantSolution.Model.InputModel
{
    public class ApplicationUserVerificationBaseInputModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        public string FullName { get; set; } = "CRM User";
        public required string EmailTemplate { get; set; }
        public string? Code { get; set; }
    }
}
