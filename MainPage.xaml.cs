namespace MvvM;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new EmployeeViewModel
        {         
            FIO = "Смирнов А.А.",
            Stuff = "Программист",
            Salary = 100200,
            Exp = 9,
            Factor = 2.25
        };
    }
}

