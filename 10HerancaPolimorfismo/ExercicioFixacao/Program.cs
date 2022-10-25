using ExercicioFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();


            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Product #1{i} data:");
                Console.Write("Common, used or imported(c / u / i) ? ");
                char ch = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price =double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsfee));
                }
                else if (ch=='c')
                {
                    list.Add(new Product
                        (name, price));
                }
                else
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                   DateTime manufacturedate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufacturedate));
                }
                

            }
            Console.WriteLine(  );
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
            
        }
    }
}
