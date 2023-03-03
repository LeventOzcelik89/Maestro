using Maestro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro.Application.Abstraction.Services
{
    public interface IUserService
    {
        public SH_User GetSH_User();
        //  public Task AddItemToBasketAsync(VM_Create_BasketItem basketItem);
        //  public Task UpdateQuantityAsync(VM_Update_BasketItem basketItem);
        public Task RemoveBasketItemAsync(string userId);
        //  public Basket? GetUserActiveBasket { get; }
    }
}
