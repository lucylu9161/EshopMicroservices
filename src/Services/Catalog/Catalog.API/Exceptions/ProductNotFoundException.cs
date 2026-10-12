//using BuildingBlocks.Exceptions;

//namespace Catalog.API.Exceptions;

//public class ProductNotFoundException : NotFoundException
//{
//    public ProductNotFoundException(Guid Id) : base("Product", Id)
//    {
//    }
//}

namespace Catalog.API.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException()
        : base("Product not found.")
    {
    }
}