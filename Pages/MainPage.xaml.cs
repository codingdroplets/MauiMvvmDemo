using MauiMvvmDemo.Models.ViewModels;

namespace MauiMvvmDemo.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void employeeButton1_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = "1001",
        //    EmployeeName = "John",
        //    Email = "john@email.com",
        //    IsPartTimer = true
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeButton2_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = "1002",
        //    EmployeeName = "Peter",
        //    Email = "peter@email.com",
        //    IsPartTimer = false
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeButton3_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = "1003",
        //    EmployeeName = "Bob",
        //    Email = "bob@email.com",
        //    IsPartTimer = true
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }
}