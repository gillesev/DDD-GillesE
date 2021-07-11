using DDDTraining.Transactions.Models;
using System;
using System.Threading.Tasks;

namespace DDDTraining.Transactions.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        public Task AddItemAsync(int sku, int quantity, ShoppingCart cart)
        {
            throw new NotImplementedException();
        }

        public Task RemoveItemAsync(int lineNumber, ShoppingCart cart)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(int lineNumber, int quantity, ShoppingCart cart)
        {
            throw new NotImplementedException();
        }
        
        public Task LinkCustomerAsync(string customerId, ShoppingCart cart)
        {
            throw new NotImplementedException();
        }        
    }
}
