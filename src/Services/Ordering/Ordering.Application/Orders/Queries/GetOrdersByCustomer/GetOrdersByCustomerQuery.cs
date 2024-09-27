using Ordering.Application.Orders.Queries.GetOrdersByCustomer;

namespace Ordering.Application.Orders.Queries.GetOrdersByCustomer;

public record GetOrdersByCustomerQuery(Guid CustomerId)
    : IQuery<GetOrdersByCustomerResult>;

public record GetOrdersByCustomerResult(IEnumerable<OrderDto> Orders);