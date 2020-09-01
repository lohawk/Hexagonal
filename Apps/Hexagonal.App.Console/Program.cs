﻿using Hexagonal.Business.Impl;
using Hexagonal.Business.Interface.Item;
using Hexagonal.Persistence.InMemory;

namespace Hexagonal.App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wire up the dependency on the application layer
            var app = new Application(new InMemoryStore());

            System.Console.WriteLine("Creating and retreiving an item");

            // Create the item
            var resp = app.Dispatch<CreateItem, BusinessItem>(new CreateItem("Hello World"));

            // Get the item back
            var item = app.Dispatch<ItemQuery, BusinessItemResult>(new ItemQuery(resp.Id));

            System.Console.WriteLine($"Created and retrieved item ({item.Results[0].Id}) with data \"{item.Results[0].Data}\"");
        }
    }
}
