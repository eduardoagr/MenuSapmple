using MenuSapmple.Model;

using System.Collections.ObjectModel;

namespace MenuSapmple.Controls;

public partial class MenuTemplate : ContentView {

    public ObservableCollection<MenuComponentItems> MenuItems { get; set; } = [];

    public MenuTemplate() {
        InitializeComponent();
        MenuItems.CollectionChanged += (sender, e) => UpdateMenu();
    }


    public static readonly BindableProperty SectionNameProperty = BindableProperty.Create(
          nameof(SectionName),
          typeof(string),
          typeof(MenuTemplate));

    public string SectionName {
        get => (string)GetValue(SectionNameProperty);
        set => SetValue(SectionNameProperty, value);
    }

    private void UpdateMenu() {
        MenuItemsStack.Children.Clear();

        foreach (var menuItem in MenuItems) {
            var imageButton = new ImageButton {
                Source = menuItem.ImageSource,
                WidthRequest = 60,
                HeightRequest = 60,
                Command = menuItem.Command,
                CommandParameter = menuItem.CommandParameter
            };

            MenuItemsStack.Children.Add(imageButton);
        }
    }
}