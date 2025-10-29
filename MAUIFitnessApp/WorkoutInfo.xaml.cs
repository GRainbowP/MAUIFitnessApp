namespace MAUIFitnessApp;

public partial class WorkoutInfo : ContentPage
{
	public WorkoutInfo()
	{
		InitializeComponent();
	}

    async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WorkoutPlans());
    }

    async void ExerciseButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WorkoutExercise());
    }
}