namespace MTenantSolution.Model.InputModel
{
    public class ApplicationUserForgotPasswordInputModel : ApplicationUserVerificationBaseInputModel
    {
        public string? Password { get; set; }
    }
}
