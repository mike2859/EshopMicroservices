 using Grpc.Core;

namespace Discount.Grpc.Services;

public class DiscountService : DiscountProtoService.DiscountProtoServiceBase
{

    public override Task<CouponModel> GetDiscount(GetDiscountRequest request, ServerCallContext context)
    {
        //TODO: GetDiscount from Database

        return base.GetDiscount(request, context);
    }

    public override Task<CouponModel> CreateDisocunt(CreateDisocuntRequest request, ServerCallContext context)
    {
        return base.CreateDisocunt(request, context);
    }

    public override Task<CouponModel> UpdateDiscount(UpdateDiscountRequest request, ServerCallContext context)
    {
        return base.UpdateDiscount(request, context);
    }

    public override Task<DeleteDiscountResponse> DeleteDiscount(DeleteDiscountRequest request, ServerCallContext context)
    {
        return base.DeleteDiscount(request, context);
    }
}
