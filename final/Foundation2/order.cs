using System;
using System.Collections.Generic;

class Order {
    private List<Product> products;
    private Customer customer;
    
    public Order(Customer customer) {
        products = new List<Product>();
        this.customer = customer;
    }
    
    public void AddProduct(Product product) {
        products.Add(product);
    }
    
    public decimal TotalPrice() {
        decimal total = 0;
        foreach (Product product in products) {
            total += product.TotalPrice;
        }
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }
    
    public string PackingLabel() {
        string label = "";
        foreach (Product product in products) {
            label += product.Name + " (" + product.Id + ")\n";
        }
        return label;
    }
    
    public string ShippingLabel() {
        return customer.Name + "\n" + customer.Address.ToString();
    }
}