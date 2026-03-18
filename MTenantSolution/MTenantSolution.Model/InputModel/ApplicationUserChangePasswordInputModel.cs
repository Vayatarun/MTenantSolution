namespace MTenantSolution.Model.InputModel
{
    public class ApplicationUserChangePasswordInputModel
    {
        public required string CurrentPassword { get; set; }
        public required string NewPassword { get; set; }
    }
}
