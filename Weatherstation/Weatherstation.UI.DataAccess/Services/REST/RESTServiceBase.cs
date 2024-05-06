using Microsoft.Extensions.Logging;

namespace Weatherstation.UI.DataAccess.Services.REST;

public class RESTServiceBase<T>(ILogger<T> logger)
{
    protected ILogger<T> _logger = logger;
    protected HttpClient _client = new();
}