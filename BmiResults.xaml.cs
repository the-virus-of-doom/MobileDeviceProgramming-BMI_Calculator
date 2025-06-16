namespace BMI_Calculator;

public partial class BmiResults : ContentPage
{
	public BmiResults(double BmiResultInput, string healthStatusInput, string recommendationsInput)
	{
		InitializeComponent();
		recommendations = recommendationsInput;

        Label_CalculatedBmi.Text = BmiResultInput.ToString("F2");
        Label_HealthStatus.Text = healthStatusInput;

    }
	string recommendations;

    private void Button_ViewHealthRecommendations(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HealthRecommendations(recommendations));
    }

    private void Button_GoBack(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}