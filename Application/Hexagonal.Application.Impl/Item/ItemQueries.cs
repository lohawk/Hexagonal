using Hexagonal.Application.Interface.Item;
using Hexagonal.Persistence.Interface;

namespace Hexagonal.Application.Impl.Item
{
    public static class ItemQueries
    {
        internal static ItemResultsDTO Query(ItemQuery query, IHandleItemState stateManager)
        {
            var item = stateManager.GetItem(query.Id);
            if (item == null) return null;

            return new ItemResultsDTO
            {
                Results = new[] {
                    new ItemDTO { Id = item.Id, Data = item.Data}
                }
            };
        }

    }
}
