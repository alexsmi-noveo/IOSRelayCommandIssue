using IOSCommandWParameterIssue.ViewModels;

namespace IOSCommandWParameterIssue;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var vm = BindingContext as MainViewModel;
        if (vm is not null) 
        {
            vm.DoNothingWParamCommand.Execute(e is not null && e.Parameter is not null ? (string)e.Parameter : null);
        }
    }
}
