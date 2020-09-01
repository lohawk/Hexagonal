using System;
using Hexagonal.Core;

namespace Hexagonal.Core.Handlers
{
    public static class ItemCommandHandlers
    {
        public static Item CreateItem(string data) =>
            new Item()
            {
                Data = data,
                ModifiedAt = DateTime.Now
            };
    }
}
