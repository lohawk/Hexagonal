namespace Hexagonal.Application.Interface.Item
{
    public interface IItemQueries
    {
        ItemResults Query(ItemQuery query);
    }

    public class ItemQuery : IApplicationQuery
    {
        public int Id { get; }

        public ItemQuery(int id) => Id = id;
    }

    public class ItemResults : IApplicationResponse
    {
        public ItemResult[] Results { get; set; }
    }

    public class ItemResult : IApplicationResponse
    {
        public int Id { get; set; }
        public string Data { get; set; }
    }
}
