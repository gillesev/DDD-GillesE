using DDDTraining.ECommerce.SharedModels;
using DDDTraining.Transactions.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDDTraining.Transactions.Services
{
    public class OrderTransactionService : IOrderTransactionService
    {
        public Task<RetailOrder> ComputeOrderDetailsAsync(ShoppingCart cart, PostalAddress shippingAddress, IList<ShippingOptions> shippingOptions, IList<PaymentMethodAllocation> paymentAllocations)
        {
            throw new NotImplementedException();
        }

        public Task<RetailOrder> PlaceOrderAsync(ShoppingCart cart, PostalAddress shippingAddress, IList<ShippingOptions> shippingOptions, IList<PaymentMethodAllocation> paymentAllocations)
        {
            throw new NotImplementedException();
        }

        public Task<RetailOrder> RequestOrderCancelAsync(RetailOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
