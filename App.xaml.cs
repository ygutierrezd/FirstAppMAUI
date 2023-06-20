using FirstSampleApp.Views;

namespace FirstSampleApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Views.GridProfile();
	}
}
