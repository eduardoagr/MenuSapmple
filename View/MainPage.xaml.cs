namespace MenuSapmple.View;

public partial class MainPage : ContentPage {

    public MainPage(MainViewModel mainViewModel) {
        BindingContext = mainViewModel;
        InitializeComponent();
        YourMainTemplate.UpdateMenu();
    }
}