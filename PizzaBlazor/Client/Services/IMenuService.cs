using PizzaBlazor.Shared;
using System.Threading.Tasks;

namespace PizzaBlazor.Client.Services
{
    interface IMenuService
    {
        Task<Menu> GetMenuAsync();
    }
}