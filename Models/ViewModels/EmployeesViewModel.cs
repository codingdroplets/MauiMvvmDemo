using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiMvvmDemo.Models.ViewModels;

internal partial class EmployeesViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Employee> employees = new();

    [ObservableProperty]
    private Employee employee = new();

    [RelayCommand]
    private void Add()
    {
        Employees.Add(Employee);
        Employee = new();
    }
}
