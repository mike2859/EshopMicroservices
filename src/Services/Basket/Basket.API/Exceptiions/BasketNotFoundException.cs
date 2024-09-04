namespace Basket.API.Exceptiions
{
    public class BasketNotFoundException : NotFoundException
    {
        public BasketNotFoundException(string userName) : base("Basket", userName) { }
            
    }
}
