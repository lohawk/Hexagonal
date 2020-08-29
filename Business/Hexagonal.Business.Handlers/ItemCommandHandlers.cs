using Hexagonal.Business.Core;
using System;

namespace Hexagonal.Business.Handlers
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
