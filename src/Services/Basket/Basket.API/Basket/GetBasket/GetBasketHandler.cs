
namespace Basket.API.Basket.GetBasket;

public record GetBaskteQuery(string UserName) : IQuery<GetBasketResult>;

public record GetBasketResult(ShoppingCart Cart);

public class GetBasketHandler : IQueryHandler<GetBaskteQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBaskteQuery query, CancellationToken cancellationToken)
    {
        //TODO: get basket from database
        //var basket = await _repository.GetBasket(query.UserName);

        return new GetBasketResult(new ShoppingCart("swn"));

    }
}
