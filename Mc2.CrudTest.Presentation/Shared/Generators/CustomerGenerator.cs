using Mc2.CrudTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mc2.CrudTest.Domain.Generators
{
    public static class CustomerGenerator
    {
        private static readonly string[] _names =
        {
            "Ali","Samad","Mamad","Guli","Ahbar","Yaghub"
        };

        public static List<Customer> GenerateCustomers()
        {

            return Enumerable.Range(1, 15).Select((index) =>
                {
                    Random rng = new();
                    return new Customer()
                    {
                        Name = _names[rng.Next(_names.Length)],
                        Address=""
                    };
                }).ToList();
        }
    }
}