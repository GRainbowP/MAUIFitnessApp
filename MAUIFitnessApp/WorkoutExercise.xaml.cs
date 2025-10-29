namespace MAUIFitnessApp;

public partial class WorkoutExercise : ContentPage
{
	public WorkoutExercise()
	{
		InitializeComponent();
	}

    async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WorkoutInfo());
    }

    async void StartWorkoutButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExerciseStart());
    }
}