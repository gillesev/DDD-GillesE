### Transactions Sub System
transactions: responsible for 
- maintaining a customer's shopping cart with its items, 
- retrieving a cart for a session
- compute an order details
- placing an order
- cancel an order

These APIs have been exposed in DDDTraining.Transactions.APIs.

DDDTraining.Transactions.BackEnd.APIs groups all back-end APIs as APIs/Interfaces for intra domain communication (but not to outside world).

The domain model is described in DDDTraining.Transactions.Models and is centered around the ShoppingCart and the RetailOrder entities.