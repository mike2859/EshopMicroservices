namespace Ordering.Domain.ValueObjects;

public record Payment
{
    public string? CardName { get; private set; } = default!;
    public string CardNumber { get; private set; } = default!;
    public string Expiratiàon { get; private set; } = default!;
    public string CVV { get; private set; } = default!;
    public int PaymentMethod { get; private set; } = default!;

}
