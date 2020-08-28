using Hexagonal.Application.Interface.Item;
using Hexagonal.Persistence.Interface;

namespace Hexagonal.Application.Impl.Item
{
    public static class ItemQueries
    {
        internal static ItemResults Query(ItemQuery query, IHandleItemState stateManager)
        {
            var item = stateManager.GetItem(query.Id);
            if (item == null) return null;

            return new ItemResults
            {
                Results = new[] {
                    new ItemResult { Id = item.Id, Data = item.Data}
                }
            };
        }

    }
}
