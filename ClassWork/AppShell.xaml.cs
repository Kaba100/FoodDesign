using ClassWork.Pages;

namespace ClassWork;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("HomePage", typeof(HomePage));
    }

}
