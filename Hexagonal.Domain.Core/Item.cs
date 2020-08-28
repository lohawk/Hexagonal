using System;

namespace Hexagonal.Domain.Core
{
    public class Item
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
