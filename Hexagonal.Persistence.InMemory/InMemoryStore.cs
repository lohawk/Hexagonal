using Hexagonal.Domain.Core;
using Hexagonal.Persistence.Interface;
using System;
using System.Collections.Generic;

namespace Hexagonal.Persistence.InMemory
{
    public class InMemoryStore : IHandleItemState
    {
        private readonly Dictionary<int, Item> _store = new Dictionary<int, Item>();

        public Item GetItem(int id)
        {
            if (_store.ContainsKey(id)) return _store[id];
            throw new InvalidOperationException();
        }

        public Item InsertItem(Item item)
        {
            if (item.Id != 0) throw new InvalidOperationException();

            item.Id = _store.Count + 1;

            _store[item.Id] = item;
            return item;
        }
    }
}
