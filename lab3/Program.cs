using lab3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                using var db = new Context();

                db.Database.EnsureCreated();
                db.Students.Add(new Student() { Name = "Jan", Surename = "Kowalski" });
                db.SaveChanges();

                var students = db.Students;

                foreach (var item in students)
                {
                    Console.WriteLine($"ID: {item.ID} Name: {item.Name} Surename: {item.Surename}");
                }

                var student = db.Students.Where(x => x.ID == 1).First();
                student.Name = "Maciek";
                db.Students.Update(student);
                db.SaveChanges();
            }


            //lista produktów z zamówienień klienta o podanym id
            {
                using var db = new NorthwindContext();


                var customers = db.Customers.Where(x => x.CustomerId == "ALFKI").ToList();




                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer ID: {customer.CustomerId}");
                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine($"\tOrder ID: {order.OrderId}");
                        foreach (var detail in order.OrderDetails)
                        {
                            Console.WriteLine($"\t\t{detail.Product.ProductName}");
                        }
                    }

                }
            }

        }
    }
}
