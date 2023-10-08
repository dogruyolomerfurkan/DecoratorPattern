namespace Business;

/// <summary>
/// Concrete Component which is decorating
/// </summary>
public class ProductService : IProductService
{
    public ProductGetModel? Get()
    {
        return new()
        {
            Id = 1,
            Name = "Phone"
        };
    }
}
