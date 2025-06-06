using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevNest.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace DevNest.ViewModel;

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<ItemViewModel> items = [];

    public HomeViewModel()
    {
        // Example initial items  
        Items.Add(new ItemViewModel(new Item
        {
            Name = "Item 1",
            Frameworks = ["Angular", "C#"],
            Description = "Test ide"
        }));
    }

    [RelayCommand]
    public void AddItem()
    {
        // Logic to add a new item  
        Items.Add(new ItemViewModel(new Item
        {
            Name = "New Item",
            Frameworks = ["React", "Node"],
            Description = "New item description"
        }));
    }
    [RelayCommand]
    public void RemoveItem(ItemViewModel item)
    {
        if (item != null && Items.Contains(item))
            Items.Remove(item);
    }

    [RelayCommand]
    public void ToggleExpand(ItemViewModel item)
    {
        if (item != null)
            item.IsExpanded = !item.IsExpanded;
    }
}
