namespace Hexagonal.Business.Interface.Item
{
    public class ItemCreated : IApplicationResponse
    {
        public int Id { get; }
        public string Data { get; }
        public string CreatedAt { get; }
    }

    public class CreateItem : IApplicationCommand
    {
        public string Data { get; set; }

        public CreateItem() { }
        public CreateItem(string data) => Data = data;
    }
}
