namespace Basket.API.Basket.GetBasket;

public record GetBaskteQuery(string UserName) : IQuery<GetBasketResult>;

public record GetBasketResult(ShoppingCart Cart);

internal class GetBasketQueryHandler(IBasketRepository repository)
    : IQueryHandler<GetBaskteQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBaskteQuery query, CancellationToken cancellationToken)
    {
        //TODO: get basket from database
        //var basket = await _repository.GetBasket(query.UserName);

        var basket = await repository.GetBasket(query.UserName);

        return new GetBasketResult(basket);

    }
}
