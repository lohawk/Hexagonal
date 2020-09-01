namespace Hexagonal.Business.Interface.Item
{
    public interface IItemQueries
    {
        BusinessItemResult Query(ItemQuery query);
    }

    public class ItemQuery : IApplicationQuery
    {
        public int Id { get; }

        public ItemQuery(int id) => Id = id;
    }

    public class BusinessItemResult : IApplicationResponse
    {
        public BusinessItem[] Results { get; set; }
    }

    public class BusinessItem : IApplicationResponse
    {
        public int Id { get; set; }
        public string Data { get; set; }
    }
}
