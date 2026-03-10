
using MTenantSolution.Model.ApplicationModels;

namespace MTenantSolution.BlazorApp.Service
{
    public interface IErrorHandlingService
    {
        Task<ResponseModel<T>> HandleErrorResponse<T>(HttpResponseMessage response);
        ResponseModel<T> HandleErrorResponse<T>(ResponseModel<T> response);
        ResponseModel<T> EnsureSuccessOrHandle<T>(ResponseModel<T>? response);
        void HandleUnauthorized();
        void RedirectToErrorPage(string exceptionMessage);
    }
}
