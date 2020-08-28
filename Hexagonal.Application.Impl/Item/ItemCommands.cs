using Hexagonal.Application.Interface.Item;
using Hexagonal.Domain.Handlers;
using Hexagonal.Persistence.Interface;

namespace Hexagonal.Application.Impl.Item
{
    public static class ItemCommands 
    {
        public static ItemResult Execute(CreateItem ci, IHandleItemState stateManager)
        {
            // Example of validation
            if (string.IsNullOrWhiteSpace(ci.Data)) return null;

            // Remember that the item returned does not have an Id.
            // We need to persist this to the store before we can get an Id
            var item = ItemCommandHandlers.CreateItem(ci.Data);
            item = stateManager.InsertItem(item);

            return new ItemResult { Id = item.Id, Data = item.Data };
        }
    }
}
