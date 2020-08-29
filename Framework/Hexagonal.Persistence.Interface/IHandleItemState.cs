namespace Hexagonal.Persistence.Interface
{
    public interface IHandleItemState
    {
        PersistedItem InsertItem(PersistedItem itemToCreate);
        PersistedItem GetItem(int id);
    }
}
