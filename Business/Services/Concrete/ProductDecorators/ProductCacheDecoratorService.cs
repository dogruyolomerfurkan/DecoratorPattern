using Microsoft.Extensions.Caching.Memory;

namespace Business;

public class ProductCacheDecoratorService : ProductDecorator
{
    private readonly IMemoryCache _memoryCache;
    public ProductCacheDecoratorService(IProductService productService, IMemoryCache memoryCache) : base(productService)
    {
        _memoryCache = memoryCache;
    }

    public override ProductGetModel? Get()
    {
        string key = "cached";
        
        return _memoryCache.GetOrCreate(key, entry =>
        {
            entry.SetAbsoluteExpiration(TimeSpan.FromMinutes(1));
            return base.Get();
        });
    }
}
