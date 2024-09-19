using FluentValidation;

namespace Ordering.Application.Orders.Commands.UpdateOrder;

public  record UpdateOrderCommand(OrderDto order)
    : ICommand<UpdateOrderResult>;

public  record UpdateOrderResult(bool IsSuccess);

public class UpdateOrderResultValidator : AbstractValidator<UpdateOrderCommand>
{
    public UpdateOrderResultValidator()
    {
        RuleFor(x => x.order.Id).NotEmpty().WithMessage("Id is required");
        RuleFor(x => x.order.OrderName).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.order.CustomerId).NotEmpty().WithMessage("Customer Id is required");
    }

}

