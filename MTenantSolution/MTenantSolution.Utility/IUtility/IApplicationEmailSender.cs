using System.Net.Mail;

namespace MTenantSolution.Utility.IUtility
{
    public interface IApplicationEmailSender
    {
        Task SendEmailAsync(MailMessage message);
    }
}
