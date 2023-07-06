using MauiMvvmDemo.Pages;

namespace MauiMvvmDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new EmployeeListPage());
	}
}
