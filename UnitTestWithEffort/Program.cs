using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestWithEffort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            FakeDbContext context = new FakeDbContext();

            var companiesData = new Company[]
            {
            new Company
            {
                Name = "Some name", Promo="Y", Contacts = new List<Contact> { new Contact {ContactName="John Doe", ContactNumber="(828)292-2912", CompanyID=1}},
               },
            new Company
            {
                Name = "Another name", Promo="N",  Contacts = new List<Contact> { new Contact {ContactName="Jane Doe", ContactNumber="(828)292-2912", CompanyID=2}},
               },
            };
            foreach (Company c in companiesData)
            {
                context.Companies.Add(c);
                foreach (Contact contact in c.Contacts)
                {
                    context.Contacts.Add(contact);
                }
            }
            context.SaveChanges();

            Console.WriteLine("Save done.");
            var companies = context.Companies.ToList();

            Console.WriteLine("companies.Count: " + companies.Count);
            for (int i = 0; i < companies.Count; i++)
            {
                Console.WriteLine(string.Format("company[{0}].Name: {1}", i, companies[i].Name));
                for (int j = 0; j < companies[i].Contacts.Count; j++)
                {
                    Console.WriteLine(string.Format("company[{0}].Contacts[{1}].ContactName: {2}", i, j, companies[i].Contacts[j].ContactName));
                }
            }

            Console.WriteLine(context.Companies.Single(c => c.Name == "Some name").Promo);
            companiesData.Single(c => c.Name == "Some name").Promo = "N";
            Console.WriteLine(context.Companies.Single(c => c.Name == "Some name").Promo);

            Console.WriteLine("Bye World");
        }
    }
}
