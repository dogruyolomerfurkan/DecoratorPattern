namespace Business;

public class ProductLogDecoratorService : ProductDecorator
{
    public ProductLogDecoratorService(IProductService productService) : base(productService)
    {
    }

    public override ProductGetModel? Get()
    {
        Console.WriteLine("Someone requested product!");
        
        return base.Get();
    }
}
