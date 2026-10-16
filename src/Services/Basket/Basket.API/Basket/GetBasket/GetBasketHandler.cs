namespace Basket.API.Basket.GetBasket;

public record GetBasketQuery(string UserName) : IQuery<GetBasketResult>;
public record GetBasketResult(ShoppingCart Cart);

public class GetBasketQueryHandler(IBasketRepository repository)
    : IQueryHandler<GetBasketQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
    {
        var basket = await repository.GetBasket(query.UserName);

        return new GetBasketResult(basket);
    }
}


//using Basket.API.Models;
//using BuildingBlocks.CQRS;

//namespace Basket.API.Basket.GetBasket;

//public record GetBasketQuery(string UserName) : IQuery<GetBasketResult>;

//public record GetBasketResult(ShoppingCart Cart);

//public class GetBasketQueryHandler : IQueryHandler<GetBasketQuery, GetBasketResult>
//{
//    public async Task<GetBasketResult> Handle(
//        GetBasketQuery query,
//        CancellationToken cancellationToken)
//    {
//        // TODO: get basket from database
//        // var basket = await _repository.GetBasket(request.UserName);

//        return new GetBasketResult(new ShoppingCart("swn"));
//    }
//}