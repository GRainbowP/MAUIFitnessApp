namespace MAUIFitnessApp
{
    public partial class MainPage : ContentPage
    {

        async void SelectCoach(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkoutPlans());
        }

        public MainPage()
        {
            InitializeComponent();
        }

        
    }
}
