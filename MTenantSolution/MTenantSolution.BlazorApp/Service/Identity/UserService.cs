
using MTenantSolution.BlazorApp.Service;
using MTenantSolution.BlazorApp.Service.Identity;
using MTenantSolution.Model.ApplicationModels;
using MTenantSolution.Model.InputModel;
using MTenantSolution.Model.ViewModel;

namespace CRM.WebBlazor.Service.Identity
{
    public class UserService(AuthenticatedHttpClientService httpClientService) : IUserService
    {
        public async Task<ResponseModel<ApplicationUserProfileViewModel>> GetUserProfileAsync()
        {
            return await httpClientService.GetAsync<ApplicationUserProfileViewModel>("Identity/User/get-user-profile");
        }

        public async Task<ResponseModel<bool>> UpdateUserProfileAsync(ApplicationUserProfileInputModel model)
        {
            return await httpClientService.PostAsync<ApplicationUserProfileInputModel, bool>("Identity/User/update-user-profile", model);
        }

        public async Task<ResponseModel<bool>> ChangePasswordAsync(ApplicationUserChangePasswordInputModel model)
        {
            return await httpClientService.PostAsync<ApplicationUserChangePasswordInputModel, bool>("Identity/User/change-password", model);
        }
    }
}
