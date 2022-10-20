﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NASA.Client.Services.LoggerServices
{
    public class LogService : ILogService
    {
        ILogger<LogService> _logger;
        public LogService(ILogger<LogService> logger)
        {
            _logger = logger;
        }

        public Task LogAsync(string message)
        {
            _logger.LogInformation(message);
            return Task.CompletedTask;
        }

        public Task TrackExceptionAsync(Exception e, string methodName)
        {
            _logger.LogError(e.Message, methodName);
            return Task.CompletedTask;
        }

        public Task TrackExceptionAsync(Exception e, string className = null, string procName = null)
        {
            _logger.LogError(e.Message, className, procName);
            return Task.CompletedTask;
        }

        public Task TrackResponseAsync(HttpResponseMessage response)
        {
            _logger.LogInformation("request " + response.RequestMessage?.RequestUri?.ToString());
            _logger.LogInformation("response " + response.StatusCode + " " + await response.Content.ReadAsStringAsync());
            return Task.CompletedTask;
        }
    }
}
