using Hexagonal.Business.Interface.Item;
using Hexagonal.Persistence.Interface;

namespace Hexagonal.Business.Impl.Item
{
    public static class ItemQueries
    {
        internal static BusinessItemResult Query(ItemQuery query, IHandleItemState stateManager)
        {
            var item = stateManager.GetItem(query.Id);
            if (item == null) return null;

            return new BusinessItemResult
            {
                Results = new[] {
                    new BusinessItem { Id = item.Id, Data = item.Data}
                }
            };
        }

    }
}
