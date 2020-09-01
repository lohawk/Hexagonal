namespace Hexagonal.Web.Controllers
{
    public class ItemDTOResult
    {
        public ItemDTO[] Results { get; set; }
    }

    public class ItemDTO 
    {
        public int Id { get; set; }
        public string Data { get; set; }
    }
}