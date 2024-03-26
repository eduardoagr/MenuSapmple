using MenuSapmple.Controls;

namespace MenuSapmple.Model;

public class MenuComponentItems : ContentView {

    public string ImageSource { get; set; }

    public string CommandParameter { get; set; }


    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
        nameof(Command), typeof(RelayCommand), typeof(MenuTemplate));

    public RelayCommand Command {
        get => (RelayCommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }


}
