using Business;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorPattern;

[ApiController, Route("v1/product")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetProduct()
    {
        return Ok(_productService.Get());
    }
}
