using System;

namespace Q5
{
    class ShoppingCart
    {
        private string[] items;
        private double[] prices;
        private int itemCount;

        public ShoppingCart(int size)
        {
            items = new string[size];
            prices = new double[size];
            itemCount = 0;
        }

        public void AddItem(string item, double price)
        {
            if (itemCount < items.Length)
            {
                items[itemCount] = item;
                prices[itemCount] = price;
                itemCount++;
                Console.WriteLine($"{item} added to cart.");
            }
            else
            {
                Console.WriteLine("Cart is full.");
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("\nItems in your cart:");
            double totalPrice = 0;
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"{items[i]} - ${prices[i]:F2}");
                totalPrice += prices[i];
            }
            Console.WriteLine($"Total Price: ${totalPrice:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items you want to add: ");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());

            ShoppingCart cart = new ShoppingCart(numberOfItems);

            string[] productNames = { "Shirt", "Jeans", "Shoes" };
            double[] productPrices = { 25.00, 50.00, 75.00 };

            for (int i = 0; i < numberOfItems; i++)
            {
                bool validChoice = false;
                while (!validChoice)
                {
                    Console.WriteLine("\nSelect an item to add to the cart:");
                    for (int j = 0; j < productNames.Length; j++)
                    {
                        Console.WriteLine($"{j + 1}. {productNames[j]} - ${productPrices[j]:F2}");
                    }
                    Console.Write("Enter your choice (1-3): ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice >= 1 && choice <= 3)
                    {
                        cart.AddItem(productNames[choice - 1], productPrices[choice - 1]);
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid item.");
                    }
                }
            }

            cart.DisplayCart();
        }
    }
}