using Ordering.Domain.Enums;

namespace Ordering.Application.Dtos;

public record OrderDto(
    Guid Id,
    Guid CustomerId,
    AddressDto ShippingAddress,
    AddressDto BillinAddress,
    PaymentDto Payment,
    OrderStatus Status,
    List<OrderItemDto> OrderItems);