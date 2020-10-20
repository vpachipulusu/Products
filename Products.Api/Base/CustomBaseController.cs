using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Products.Api.Base
{
    public abstract class CustomBaseController : ControllerBase
    {
        protected virtual void LogInformation<LoggerType>(string message, params object[] args)
        {
            var log = HttpContext.RequestServices.GetService<ILogger<LoggerType>>();
            if (args.Length > 0)
            {
                log.LogInformation(message, args);
            }
            else
            {
                log.LogInformation(message);
            }
        }

        protected virtual void LogError<LoggerType>(Exception exception, string message = null, params object[] args)
        {
            var log = HttpContext.RequestServices.GetService<ILogger<CustomBaseController>>();
            if (args.Length > 0)
            {
                log.LogError(exception, message ?? exception.Message, args);
            }
            else
            {
                log.LogError(exception, message ?? exception.Message);
            }
        }
    }
}
