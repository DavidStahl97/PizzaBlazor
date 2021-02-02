using PizzaBlazor.Shared;
using System.Threading.Tasks;

namespace PizzaBlazor.Client.Services
{
    public interface IOrderService
    {
        Task PlaceOrderAsync(Basket basket);
    }
}