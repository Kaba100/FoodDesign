using ClassWork.NewFolder;
namespace ClassWork.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{

		InitializeComponent();
        BindingContext = new FoodVM();
    }
}