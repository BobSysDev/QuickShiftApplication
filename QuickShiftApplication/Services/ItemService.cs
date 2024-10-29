namespace QuickShiftApplication.Services;

public class ItemService
{
    private readonly List<string> _items = new List<string>();

    public void AddItem(string item)
    {
        _items.Add(item);
    }

    public List<string> GetItems()
    {
        return _items;
    }
}