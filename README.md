# DDD-GillesE
Magenic DDD Class

Gilles Eveloy
gilles.eveloy@softvision.com
gillese@magenic.com

# GitHub Repo
https://github.com/gillesev/DDD-GillesE

# Week 1
I chose to implement a large e-commerce system with 3 sub systems:
- productcatalog: responsible for maintaining which product is active when, prices and (maybe) product relationships.
    - maintain core product features (merchant team actor)
    - activate/terminate a product (merchant team actor)
    - maintain product pricing (pricing team actor)
    - maintain product content management (content mgmt team actor)
- shoppingcart: responsible for 
    - maintaining a customer's shopping cart with its items, 
    - compute the item/cart prices (apply promotions),
    - compute the taxes and cart net total,
    - process customer's payment (checkout)
- ordermanagement: responsible for creating an order and fullfill the order
    - create an order as a result of a valid customer transaction
    - fullfill the order (order translates into 1 or multiple shipments)
    - provide order level/shipment level status
    - send notifications to customer (product no more available, ETC...)
- inventorymanagement (less knowledgeable) responsible for:
    - update product inventory
    - compute demand forecasts
    - create replinishment orders

We will therefore concern ourselves with creating 4 separate sub systems with their respective business processes. These sub systems are centered around what business value or process they are enabling, not concepts like SKU, Customer, Order.


