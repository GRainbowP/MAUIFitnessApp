using System.Threading.Tasks;

namespace MAUIFitnessApp;

public partial class WorkoutPlans : ContentPage
{
	public WorkoutPlans()
	{
		InitializeComponent();
		//Navigation.PopAsync();
	}

    async void BackButton(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}