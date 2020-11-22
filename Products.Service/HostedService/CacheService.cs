using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Hosting;
using Products.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Products.Service.HostedService
{
    public class CacheService : IHostedService
    {
        private readonly IMemoryCache _cache;
        private readonly IOrganizationBaseRepository _organizationBaseService;
        private const string CacheApiKeyName = "ApiKeys";

        public CacheService(IMemoryCache cache, IOrganizationBaseRepository organizationBaseService)
        {
            _cache = cache;
            _organizationBaseService = organizationBaseService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var organizationApiKeys = _cache.Get(CacheApiKeyName);
            if (organizationApiKeys == null)
            {
                var organizationBase = await _organizationBaseService.GetAll();
                if (organizationBase != null)
                {
                    List<string> apiKeys = organizationBase.Select(s => s.OAuthKey).ToList();
                    _cache.Set(CacheApiKeyName, apiKeys);
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _cache.Remove(CacheApiKeyName);
            return Task.CompletedTask;
        }
    }
}
