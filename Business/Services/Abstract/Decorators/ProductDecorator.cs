namespace Business;

/// <summary>
/// Base Decorator, it should contain IProductService for implementing decoration method. Method should be virtual
/// for override.
/// </summary>
public abstract class ProductDecorator : IProductService
{
    private readonly IProductService _productService;

    protected ProductDecorator(IProductService productService)
    {
        _productService = productService;
    }

    public virtual ProductGetModel? Get()
    {
        return _productService.Get();
    }
}
