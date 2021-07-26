# DDD-GillesE
Magenic DDD Class

Gilles Eveloy
gilles.eveloy@softvision.com
gillese@magenic.com

# GitHub Repo
https://github.com/gillesev/DDD-GillesE

# E-Commerce DDD-Training Application
I chose to implement a imaginary e-commerce system with the following sub systems/domains:
- transactions: responsible for 
    - maintaining a customer's shopping cart with its items, 
    - compute the item/cart prices (apply promotions),
    - compute the taxes and cart net total,
    - process customer's payment (checkout)
    - send customer notifications
- paymentgateway: responsible for processing payment requests and posting responses
    - process and authorization
    - process timeout reversal
    - voids an authorization
- orderfulfillment: responsible for creating the customer order and sourcing orders
    - create a customer order as a result of a retail order/transaction (order placed)
    - fullfill the order (order translates into 1 or multiple shipments)
    - process full/partial cancellation of a customer order.
- ordershipping (less knowledgeable) responsible for:
    - create 1 to N shipments from 1 sourced order
    - process the cancellation of 1 to N shipments triggered by the cancellation of 1 to N sourced orders.
- productcatalog: responsible for maintaining which product is active when, prices and (maybe) product relationships.
    - maintain core product features (merchant team actor)
    - activate/terminate a product (merchant team actor)
    - maintain product pricing (pricing team actor)
    - maintain product content management (content mgmt team actor)
- customerhistory: responsible for providing customer historical retail orders/transactions (sales, returns ETC...)

The 3 domains that have been fleshed out are:
- transactions (shopping cart and order placement)
- paymentgateway
- orderfulfillment

Domains expose APIs (vastly json over http) for external consumption but communicate between each other using EVENT messages.

The Framework contains shared Kernels interfaces but should be consumed as a semVer package.
