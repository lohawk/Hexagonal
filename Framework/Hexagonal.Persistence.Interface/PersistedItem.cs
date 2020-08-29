using System;

namespace Hexagonal.Persistence.Interface
{
    public class PersistedItem
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
