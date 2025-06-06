using CommunityToolkit.Mvvm.ComponentModel;

namespace DevNest.Model;

public partial class Item : ObservableObject
{
    public string? Name { get; set; }
    public string[]? Frameworks { get; set; }
    public string? Description { get; set; }
    public string FrameworksString => Frameworks != null ? string.Join(", ", Frameworks) : string.Empty;
}
