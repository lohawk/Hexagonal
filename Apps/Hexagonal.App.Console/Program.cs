using Hexagonal.Application.Interface.Item;
using Hexagonal.Persistence.InMemory;

namespace Hexagonal.App.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wire up the dependency on the application layer
            var app = new Application.Impl.Application(new InMemoryStore());

            System.Console.WriteLine("Creating and retreiving an item");

            // Create the item
            var resp = app.Dispatch<CreateItem, ItemDTO>(new CreateItem("Hello World"));

            // Get the item back
            var item = app.Dispatch<ItemQuery, ItemResultsDTO>(new ItemQuery(resp.Id));

            System.Console.WriteLine($"Created and retrieved item ({item.Results[0].Id}) with data \"{item.Results[0].Data}\"");
        }
    }
}
