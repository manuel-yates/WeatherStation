using Microsoft.Extensions.Logging;
using NUnit.Framework.Legacy;

namespace Weatherstation.UI.DataAccess.Services.Mocking;

public class MockServiceBase(ILogger<MockServiceBase> logger)
{
    private ILogger _logger = logger;
}