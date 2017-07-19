namespace _08ShoppingSpree
{
    using _08ShoppingSpree.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] peopleTokens = Console.ReadLine()
                .Trim()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productsTokens = Console.ReadLine()
                .Trim()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (var pers in peopleTokens)
                {
                    int index = pers.IndexOf('=');
                    string personName = pers.Substring(0, index);
                    decimal money = decimal.Parse(pers.Substring(index + 1));

                    Person person = new Person(personName, money);
                    people.Add(person);
                }

                foreach (var prod in productsTokens)
                {
                    int index = prod.IndexOf('=');
                    string productName = prod.Substring(0, index);
                    decimal cost = decimal.Parse(prod.Substring(index + 1));

                    Product product = new Product(productName, cost);
                    products.Add(product);
                }

                string inputLine;
                while ((inputLine = Console.ReadLine()) != "END")
                {
                    string[] tokens = inputLine.Split();
                    Person person = people.Where(p => p.Name == tokens[0]).FirstOrDefault();
                    Product product = products.Where(p => p.Name == tokens[1]).FirstOrDefault();


                    if (person.Money < product.Cost)
                    {

                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }
                    else
                    {
                        people.Where(p => p.Name == person.Name).FirstOrDefault().AddProduct(product);
                        people.Where(p => p.Name == person.Name).FirstOrDefault().Money -= product.Cost;
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                }

                foreach (var person in people)
                {
                    if (person.Products.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p => p.Name))}");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
