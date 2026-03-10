using MTenantSolution.Model.ApplicationModels;
using MTenantSolution.Model.InputModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTenantSolution.Services.Identitty
{
    public  interface IAuthenticationService
    {
        Task<ResponseModel<AuthenticationTokens>> LoginAsync(ApplicationUserLoginInputModel model);
        Task<ResponseModel<bool>> RegisterAsync(ApplicationUserRegisterInputModel model);
        Task<ResponseModel<bool>> ConfirmEmailAsync(ApplicationUserConfirmEmailInputModel model);
        Task<ResponseModel<bool>> ConfirmEmailVerifyCodeAsync(ApplicationUserConfirmEmailInputModel model);
        Task<ResponseModel<bool>> ForgotPasswordAsync(ApplicationUserForgotPasswordInputModel model);
        Task<ResponseModel<bool>> ResetPasswordAsync(ApplicationUserForgotPasswordInputModel model);
        Task<ResponseModel<AuthenticationTokens>> RefreshTokenAsync(AuthenticationTokens model);


    }
}
