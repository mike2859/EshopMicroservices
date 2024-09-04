namespace Basket.API.Basket.GetBasket;

//public record GetBasketRequest(string UserName);

public record GetBasketResponse(ShoppingCart Cart);
internal class GetBasketEndpoint : ICarterModule
{
    public async void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/basket/{UserName}", async (string userName, ISender sender) =>
        {
            var result = await sender.Send(new GetBaskteQuery(userName));

            var response = result.Adapt<GetBasketResponse>();


            return Results.Ok(response);

        })
            .WithName("GetBasket")
            .Produces<GetBasketResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get Basket")
            .WithDescription("Get Basket");
    }
}
