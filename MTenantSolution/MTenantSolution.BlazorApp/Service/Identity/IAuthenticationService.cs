
using MTenantSolution.Model.ApplicationModels;
using MTenantSolution.Model.InputModel;

namespace MTenantSolution.BlazorApp.Service.Identity
{
    public interface IAuthenticationService
    {
        Task<ResponseModel<AuthenticationTokens>> LoginAsync(ApplicationUserLoginInputModel model);
        Task<ResponseModel<bool>> RegisterAsync(ApplicationUserRegisterInputModel model);
        Task<ResponseModel<bool>> ConfirmEmailAsync(ApplicationUserConfirmEmailInputModel model);
        Task<ResponseModel<bool>> VerifyEmailCodeAsync(ApplicationUserConfirmEmailInputModel model);
        Task<ResponseModel<bool>> ForgotPasswordAsync(ApplicationUserForgotPasswordInputModel model);
        Task<ResponseModel<bool>> ResetPasswordAsync(ApplicationUserForgotPasswordInputModel model);
    }
}
