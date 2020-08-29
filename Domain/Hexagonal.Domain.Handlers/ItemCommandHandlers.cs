using Hexagonal.Domain.Core;
using System;

namespace Hexagonal.Domain.Handlers
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
