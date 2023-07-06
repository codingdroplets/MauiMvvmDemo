using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiMvvmDemo.Models.ViewModels;

internal partial class EmployeeDetailViewModel2 : ObservableObject
{
    [ObservableProperty]
    private Employee employee;
}
