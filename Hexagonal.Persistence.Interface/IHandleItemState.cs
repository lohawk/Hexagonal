using Hexagonal.Domain.Core;

namespace Hexagonal.Persistence.Interface
{
    public interface IHandleItemState
    {
        Item InsertItem(Item itemToCreate);
        Item GetItem(int id);
    }
}
