namespace MAUIFitnessApp;

public partial class ExerciseStart : ContentPage
{
	public ExerciseStart()
	{
		InitializeComponent();
	}

    async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WorkoutExercise());
    }
}