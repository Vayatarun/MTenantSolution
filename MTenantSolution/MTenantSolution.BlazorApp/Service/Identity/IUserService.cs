
using MTenantSolution.Model.ApplicationModels;
using MTenantSolution.Model.InputModel;
using MTenantSolution.Model.ViewModel;

namespace MTenantSolution.BlazorApp.Service.Identity
{
    public interface IUserService
    {
        Task<ResponseModel<ApplicationUserProfileViewModel>> GetUserProfileAsync();
        Task<ResponseModel<bool>> UpdateUserProfileAsync(ApplicationUserProfileInputModel model);
        Task<ResponseModel<bool>> ChangePasswordAsync(ApplicationUserChangePasswordInputModel model);
    }
}
