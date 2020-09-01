using Hexagonal.Business.Interface.Item;
using Hexagonal.Core.Handlers;
using Hexagonal.Persistence.Interface;

namespace Hexagonal.Business.Impl.Item
{
    public static class ItemCommands 
    {
        public static BusinessItem Execute(CreateItem ci, IHandleItemState stateManager)
        {
            // Example of validation
            if (string.IsNullOrWhiteSpace(ci.Data)) return null;

            // Remember that the item returned does not have an Id.
            // We need to persist this to the store before we can get an Id
            var item = ItemCommandHandlers.CreateItem(ci.Data);
            var persistedItem = stateManager.InsertItem(new PersistedItem
            {
                Id = item.Id,
                Data = item.Data,
                ModifiedAt = item.ModifiedAt
            });

            return new BusinessItem
            {
                Id = persistedItem.Id,
                Data = persistedItem.Data
            };
        }
    }
}
