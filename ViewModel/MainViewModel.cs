

namespace MenuSapmple.ViewModel;

public partial class MainViewModel : ObservableObject {


    [RelayCommand]
    public void MenuItemSelected() {

        Debug.WriteLine("dcd");
    }
}
