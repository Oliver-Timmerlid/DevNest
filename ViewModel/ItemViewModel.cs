using CommunityToolkit.Mvvm.ComponentModel;
using DevNest.Model;

namespace DevNest.ViewModel;

public partial class ItemViewModel(Item item) : ObservableObject
{
    public Item Item { get; } = item;
    [ObservableProperty]
    private bool isExpanded = false;

    public string? Name => Item.Name;
    public string? Description => Item.Description;
    public string FrameworksString => Item.Frameworks != null ? string.Join(", ", Item.Frameworks) : string.Empty;

    

    
}
