using System.ComponentModel;

namespace MauiMvvmDemo.Models.ViewModels;

internal class EmployeeDetailViewModel : INotifyPropertyChanged
{
    private string employeeName;

    public string EmployeeId { get; set; }
    
    public string EmployeeName
    {
        get { return employeeName; } 
        set
        {
            employeeName = value;
            NotifyPropertyChanged(nameof(EmployeeName));
        }
    }

    public string Email { get; set; }
    public bool IsPartTimer { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
