# DDD-GillesE
Magenic DDD Class

Gilles Eveloy
gilles.eveloy@softvision.com
gillese@magenic.com

# Week 1
I am starting the project from https://github.com/Magenic/DDD

I can see that 1 business domain exists called eShop which may represent an e-Commerce shopping cart domain.
However, it is not clear yet what this domain responsabilities are, e.g. what it is that it does.

I can see that the AddressBase & AddressKind are value objects and that is ok.

I am not sure that IPerson as a contact is warranted as could we have a person without being a customer and the interface does not define a firstname/lastname. I would move the contact fields to ICustomer and rid of IPerson.

The customer profile seems to be a profile to segment the customer. He effectively can belong to multiple segments. Maybe ICustomer could have a relationship to ICustomer Customer.

ISku represents the catalog product without its price as the price may change frequently.

The ICustomerOrder should point to a list of ICustomerOrderItem and not directly a list of ISku. We are missing a concept of order item which could be:

ICustomerOrderItem {
    ISku Sku {get; set;}
    decimal UnitPrice {get; set;}
    int Quantity {get; set;}
    decimal TotalPrice {get; set;}
}