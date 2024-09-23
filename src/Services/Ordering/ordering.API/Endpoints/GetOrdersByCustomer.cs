using Ordering.Application.Orders.Queries.GetOrdersByCustomer;

namespace Ordering.API.Endpoints;

// Accept a customer ID.
// Uses a GetOrderByCustomerQuery to fetch orders.
// Returns the list of orders for that customer.

//public record GetOrderByCustomerRequest(Guid Id)

public record GetOrderByCustomerResponse(IEnumerable<OrderDto> Orders);

public class GetOrdersByCustomer : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/order/{customerId}", async (Guid customerId, ISender sender) =>
        {
            var result = await sender.Send(new GetOrdersByCustomerQuery(customerId));

            var response = Results.Ok(result);
        })
        .WithName("GetOrdersByCustomer")
        .Produces<GetOrderByCustomerResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Orders By Customer")
        .WithDescription("Get Orders By Customer");
    }
}
