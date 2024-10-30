using Microsoft.AspNetCore.Mvc.Filters;

namespace ViewBagExample.Filters
{
    public class LogActionFilter : IActionFilter
    {
        private readonly ILogger<LogActionFilter> _logger;

        public LogActionFilter(ILogger<LogActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"Action '{context.ActionDescriptor.DisplayName}' is starting.");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation($"Action '{context.ActionDescriptor.DisplayName}' has completed.");
        }
    }
}
