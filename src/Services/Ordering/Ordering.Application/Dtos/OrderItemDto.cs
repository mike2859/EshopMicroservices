namespace Ordering.Application.Dtos;

public record OrderItemDto(Guid OrderId, Guid ProductId, int Quentity, decimal Price);