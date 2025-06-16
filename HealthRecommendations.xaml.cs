namespace BMI_Calculator;

public partial class HealthRecommendations : ContentPage
{
	public HealthRecommendations(string healthRecommendations)
	{
		InitializeComponent();
		Label_HealthRecommendation.Text = healthRecommendations;
	}

    private void Button_GoBack(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void Button_Restart(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}