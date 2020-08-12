using System;
using System.Collections.Generic;

namespace BeautySSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            var visit = new Visit();
            visit.Discount = new Discount();
            //visit.Discount.Discoun = 20 / 100.0;

            visit.Customer = new Customer("Petar");
            visit.Customer.Membership = new Premium();

            visit.Items.Add(new Item(100, ProductType.Service));
            visit.Items.Add(new Item(100, ProductType.Product));
            visit.Items.Add(new Item(100, ProductType.Product));

            Console.WriteLine(visit.Total());


            var test = "abbccbba";
            var isPalindrom = true;
            for (int i = 0; i < test.Length / 2; i++)
            {
                if (test[i] != test[test.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrom);

            var list = new List<int>() { 12, 23, 8, 21, 3 };
            var pom = 0;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if(list[j] > list[j+1])
                    {
                        pom = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = pom;
                    }
                    Print(list);
                }
            }
        }

        static void Print(List<int> items)
        {
            foreach (var item in items)
            {
                Console.Write(item);
                Console.Write("  ");
            }

            Console.WriteLine();
        }
    }
}
