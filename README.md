# DDD-GillesE
Magenic DDD Class

Gilles Eveloy
gilles.eveloy@softvision.com
gillese@magenic.com

# GitHub Repo
https://github.com/gillesev/DDD-GillesE

# E-Commerce DDD-GillesE Application - List of sub systems (e.g. domains) at a High Level
I chose to implement a large e-commerce system with 3 sub systems:
- shoppingcart: responsible for 
    - maintaining a customer's shopping cart with its items, 
    - compute the item/cart prices (apply promotions),
    - compute the taxes and cart net total,
    - checkout the cart by orchesrating the customer's payment and order creation
    - send notifications to customer (order confirmation # ETC...)
- ordermanagement: responsible for creating an order and fullfill the order
    - create an order as a result of a valid customer transaction
    - fullfill the order (order translates into 1 or multiple shipments)
    - provide order level/shipment level status
    - send notifications to customer (product no more available, ETC...)
    - cancel an existing order
- paymentgateway: responsible for processing payment authorization requests and responses
    - authorize a request
- inventorymanagement (less knowledgeable) responsible for:
    - update product inventory
    - compute demand forecasts
    - create replinishment orders
- productcatalog: responsible for
    - maintaining product information (Categorization, merchandising, content management)

We will focus on the shoppingcart, ordermanagement and paymentgateway domains.


