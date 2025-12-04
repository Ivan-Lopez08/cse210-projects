using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Ivan Lopez0", "Col. El Hogar, Bloque D", "Tegucigalpa", "Francisco Morazan", "HN");
        Customer customer2 = new Customer("Bryan Salgado", "8500 Pine Dr Apt 3B", "Houston", "TX", "USA");


    }

    static Order placeOrder(Customer customer, int NumberOfProducts)
    {
        Order order = new Order(customer);

        for (int i = 0; i < NumberOfProducts; i++)
        {
            Product product = new Product("Test product 1", "PR00001", 12.5f , 5);
            order.AddProduct(product);
        }

        return order;
    }
}