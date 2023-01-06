namespace MauiAppML;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Created += (s, e) =>
        {
            ((AppShell)window.Page).OnAppWindowCreated();
        };

        window.Activated += (s, e) =>
        {
            ((AppShell)window.Page).OnAppWindowActivated();
        };

        window.Resumed += (s, e) =>
        {
            ((AppShell)window.Page).OnAppWindowResumed();
        };

        window.Backgrounding += (s, e) =>
        {
            ((AppShell)window.Page).OnAppWindowBackgrounding();
        };

        window.Stopped += (s, e) =>
        {
            ((AppShell)window.Page).OnAppWindowStopped();
        };

        window.Destroying += (s, e) =>
        {
            ((AppShell)window.Page).OnAppWindowDestroying();
        };

        return window;
    }
}