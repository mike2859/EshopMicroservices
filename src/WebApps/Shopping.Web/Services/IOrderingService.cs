namespace Shopping.Web.Services;

public interface IOrderingService
{

    [Get("/ordering-service/orders?pageIndex={pageNumber}&pageSize={pageSize}")]
    Task<GetOrdersResponse> GetProductsAsync(int? pageIndex = 1, int? pageSize = 10);


    [Get("/ordering-service/orders/{orderName}")]
    Task<GetOrdersByNameResponse> GetOrdersByNameAsync(string orderName);

    [Get("/ordering-service/orders/customer/{customerId}")]
    Task<GetProductByCategoryResponse> GetProductsByCategoryAsync(Guid customerId);
}
