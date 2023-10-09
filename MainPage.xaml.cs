namespace LAB_COMPROG1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	async void OnDial(object sender, EventArgs e)
	{
		try
		{
			PhoneDialer.Open(PhoneNum.Text);
			Convert.ToInt32(PhoneNum.Text);	
		}
		catch
		{
			await DisplayAlert("Invalid Input", "Please enter a valid phone number", "OK");
		}
	}
	
}


