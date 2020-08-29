namespace Hexagonal.Application.Interface.Item
{
    public interface IItemQueries
    {
        ItemResultsDTO Query(ItemQuery query);
    }

    public class ItemQuery : IApplicationQuery
    {
        public int Id { get; }

        public ItemQuery(int id) => Id = id;
    }

    public class ItemResultsDTO : IApplicationResponse
    {
        public ItemDTO[] Results { get; set; }
    }

    public class ItemDTO : IApplicationResponse
    {
        public int Id { get; set; }
        public string Data { get; set; }
    }
}
