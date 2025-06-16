namespace BMI_Calculator;

public partial class BMI : ContentPage
{
	public BMI()
	{
		InitializeComponent();
	}

    private string gender = "Male";
    private double BmiResult = 0;
    private string healthStatus = "";
    private string recommendations = "";

    private void CalculateBmi(double weight, double height)
    {
        BmiResult = (weight * 703) / (height * height);
        healthStatus = GetBmiStatus(weight, height);
        recommendations = GetRecommendations(healthStatus);
    }

    private string GetBmiStatus(double weight, double height)
    {
        if (gender == "Male")
        {
            if (BmiResult < 18.5)
            {
                return "Underweight";
            }
            else if (BmiResult < 25)
            {
                return "Normal Weight";
            }
            else if (BmiResult < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
        else if (gender == "Female")
        {
            if (BmiResult < 18.5)
            {
                return "Underweight";
            }
            else if (BmiResult < 25)
            {
                return "Normal Weight";
            }
            else if (BmiResult < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
        else
        {
            return "You shouldn't be able to see this!";
        }
    }

    private string GetRecommendations(string BmiCategory)
    {
        switch (BmiCategory)
        {
            case "Underweight":
                return "Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains). Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
            case "Normal Weight":
                return "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health.";
            case "Overweight":
                return "Reduce processed foods and focus on portion control. Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. Drink plenty of water and track your progress.";
            case "Obese":
                return "Consult a doctor for personalized guidance. Start with low-impact exercises (e.g., walking, cycling). Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
            default:
                return "You shouldn't be able to see this!";
        }
    }

    private void Button_Calculate_BMI(object sender, EventArgs e)
    {
        double weight = SliderWeight.Value;
        double height = SliderHeight.Value;

        CalculateBmi(weight, height);

        string resultsString = "";
        resultsString += "Gender: " + gender;
        resultsString += "\nBMI: " + BmiResult.ToString("F2");
        resultsString += "\nHealth Status: " + healthStatus;
        resultsString += "\nRecommendations:\n" + recommendations;

        DisplayAlert("Your calculated BMI results are:", resultsString, "Ok");
        Navigation.PushAsync(new BmiResults(BmiResult, healthStatus, recommendations));
    }

    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        gender = "Male";
        FrameMale.BackgroundColor = Color.FromArgb("#e8e8e8");
        FrameMale.BorderColor = Color.FromArgb("#4d4d4");
        FrameFemale.BackgroundColor = Color.FromArgb("#ffffff");
        FrameFemale.BorderColor = Color.FromArgb("#c8c8c8");
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        gender = "Female";
        FrameMale.BackgroundColor = Color.FromArgb("#ffffff");
        FrameMale.BorderColor = Color.FromArgb("#c8c8c8");
        FrameFemale.BackgroundColor = Color.FromArgb("#e8e8e8");
        FrameFemale.BorderColor = Color.FromArgb("#4d4d4");
    }
}