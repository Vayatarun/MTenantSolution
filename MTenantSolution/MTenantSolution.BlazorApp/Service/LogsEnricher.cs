using Serilog.Core;
using Serilog.Events;

namespace MTenantSolution.BlazorApp.Service
{
    public class LogsEnricher : ILogEventEnricher
    {
        public static string? CurrentUserEmail { get; set; }

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            if (!string.IsNullOrWhiteSpace(CurrentUserEmail))
            {
                var emailProperty = propertyFactory.CreateProperty("UserEmail", CurrentUserEmail);
                logEvent.AddOrUpdateProperty(emailProperty);
            }
        }
    }
}
