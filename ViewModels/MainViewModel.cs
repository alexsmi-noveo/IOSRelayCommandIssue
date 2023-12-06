using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace IOSCommandWParameterIssue.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string strParam = "Some default param";

    [RelayCommand]
    async Task DoNothingWParam(string param) 
        => await Shell.Current.DisplayAlert("alert", string.IsNullOrEmpty(param) ? "Parameter is empty" : string.Format("Parameter is not empty. Message is: {0}", param), "ok");
}
