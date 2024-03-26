namespace MenuSapmple.ViewModel;
public partial class BaseViewModel(string title) : ObservableObject {

    [ObservableProperty]
    bool isBusy;

    [ObservableProperty]
    string title = title;
}
