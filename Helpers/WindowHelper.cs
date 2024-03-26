namespace MenuSapmple.Helpers;

public static class WindowHelper {

    public static void CreateWindow(Page view, double height, double width, double x = 0, double y = 0) {

        var displayInfo = DeviceDisplay.MainDisplayInfo;

        if (height == 0 && width == 0) {

            width = displayInfo.Width;
            height = displayInfo.Height;
        }

        var newWindow = new Window() {

            Page = view,

            Height = height,

            Width = width,

            X = x,

            Y = y,

        };

        Application.Current?.OpenWindow(newWindow);
    }
}
