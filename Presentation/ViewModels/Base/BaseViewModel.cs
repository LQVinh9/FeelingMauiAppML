using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiAppML.Presentation.ViewModels.Base;

public class BaseViewModel : INotifyPropertyChanged
{
    public Dictionary<string, ICommand> Commands { get; protected set; }

    private bool isBusy = false;

    public bool IsBusy
    {
        get { return isBusy; }
        set { SetProperty(ref isBusy, value); }
    }

    private string title = string.Empty;

    public string Title
    {
        get { return title; }
        set { SetProperty(ref title, value); }
    }

    protected bool SetProperty<T>(ref T backingStore, T value,
        [CallerMemberName] string propertyName = "",
        Action onChanged = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
            return false;

        backingStore = value;

        onChanged?.Invoke();

        OnPropertyChanged(propertyName);
        return true;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public BaseViewModel()
    {
        Commands = new Dictionary<string, ICommand>();
    }

    public virtual void OnPageAppearing()
    {
    }

    public virtual void OnPageDisappearing()
    {
    }

    public virtual void OnBackButtonPressed()
    {
    }

    public virtual void OnNavigatedFrom()
    {
    }

    public virtual void OnNavigatingFrom()
    {
    }

    public virtual void OnNavigatedTo()
    {
    }

    public virtual void OnAppWindowCreated()
    {
    }

    public virtual void OnAppWindowActivated()
    {
    }

    public virtual void OnAppWindowResumed()
    {
    }

    public virtual void OnAppWindowBackgrounding()
    {
    }

    public virtual void OnAppWindowStopped()
    {
    }

    public virtual void OnAppWindowDestroying()
    {
    }
}