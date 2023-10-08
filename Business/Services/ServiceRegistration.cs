using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class ServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddMemoryCache();

        //Returned Service will be working first(here ProductLogDecoratorService), 
        //then next decorator will be the one which is calling returned services constructor(here ProductCache)
        //You can chain as much as you needed
        services.AddScoped<IProductService>(provider =>
        {
            var productService = new ProductService();

            var memoryCache = provider.GetRequiredService<IMemoryCache>();

            var productCacheService = new ProductCacheDecoratorService(productService, memoryCache);

            return new ProductLogDecoratorService(productCacheService);
        });

        return services;
    }
}
