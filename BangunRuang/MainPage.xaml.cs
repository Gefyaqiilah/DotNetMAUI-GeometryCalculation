namespace BangunRuang;

public partial class MainPage : ContentPage
{
    int mode = -1;

	public MainPage()
	{
		InitializeComponent();
	}


private void Kubus_Clicked(object sender, EventArgs e) {
    mode = 1;
cubeSideEntry.IsVisible = false;
button_kubus.IsVisible = false;
button_balok.IsVisible = false;
button_tabung.IsVisible = false;
button_bola.IsVisible = false;
button_kerucut.IsVisible = false;
button_back.IsVisible = true;
button_calculate.IsVisible = true;
resultLabel.IsVisible = true;
cubeSideLabel.IsVisible = true;
cubeSideEntry.IsVisible = true;
prismWidthLabel.IsVisible = false;
prismWidthEntry.IsVisible = false;
prismHeightLabel.IsVisible = false;
prismHeightEntry.IsVisible = false;
cylinderRadiusLabel.IsVisible = false;
cylinderRadiusEntry.IsVisible = false;
cylinderHeightLabel.IsVisible = false;
cylinderHeightEntry.IsVisible = false;
sphereRadiusLabel.IsVisible = false;
sphereRadiusEntry.IsVisible = false;
coneRadiusLabel.IsVisible = false;
coneRadiusEntry.IsVisible = false;
coneHeightLabel.IsVisible = false;
coneHeightEntry.IsVisible = false;
}
private void Balok_Clicked(object sender, EventArgs e) {
    mode = 2;
cubeSideEntry.IsVisible = false;
button_kubus.IsVisible = false;
button_balok.IsVisible = false;
button_tabung.IsVisible = false;
button_bola.IsVisible = false;
button_kerucut.IsVisible = false;
button_back.IsVisible = true;
button_calculate.IsVisible = true;
resultLabel.IsVisible = true;
prismLengthLabel.IsVisible = true;
prismLengthEntry.IsVisible = true;
cubeSideLabel.IsVisible = false;
cubeSideEntry.IsVisible = false;
prismWidthLabel.IsVisible = true;
prismWidthEntry.IsVisible = true;
prismHeightLabel.IsVisible = true;
prismHeightEntry.IsVisible = true;
cylinderRadiusLabel.IsVisible = false;
cylinderRadiusEntry.IsVisible = false;
cylinderHeightLabel.IsVisible = false;
cylinderHeightEntry.IsVisible = false;
sphereRadiusLabel.IsVisible = false;
sphereRadiusEntry.IsVisible = false;
coneRadiusLabel.IsVisible = false;
coneRadiusEntry.IsVisible = false;
coneHeightLabel.IsVisible = false;
coneHeightEntry.IsVisible = false;
}
private void Tabung_Clicked(object sender, EventArgs e) {
    mode = 3;
cubeSideEntry.IsVisible = false;
button_kubus.IsVisible = false;
button_balok.IsVisible = false;
button_tabung.IsVisible = false;
button_bola.IsVisible = false;
button_kerucut.IsVisible = false;
button_back.IsVisible = true;
button_calculate.IsVisible = true;
resultLabel.IsVisible = true;
prismLengthLabel.IsVisible = false;
prismLengthEntry.IsVisible = false;
cubeSideLabel.IsVisible = false;
cubeSideEntry.IsVisible = false;
prismWidthLabel.IsVisible = false;
prismWidthEntry.IsVisible = false;
prismHeightLabel.IsVisible = false;
prismHeightEntry.IsVisible = false;
cylinderRadiusLabel.IsVisible = true;
cylinderRadiusEntry.IsVisible = true;
cylinderHeightLabel.IsVisible = true;
cylinderHeightEntry.IsVisible = true;
sphereRadiusLabel.IsVisible = false;
sphereRadiusEntry.IsVisible = false;
coneRadiusLabel.IsVisible = false;
coneRadiusEntry.IsVisible = false;
coneHeightLabel.IsVisible = false;
coneHeightEntry.IsVisible = false;
}
private void Bola_Clicked(object sender, EventArgs e) {
    mode = 4;
cubeSideEntry.IsVisible = false;
button_kubus.IsVisible = false;
button_balok.IsVisible = false;
button_tabung.IsVisible = false;
button_bola.IsVisible = false;
button_kerucut.IsVisible = false;
button_back.IsVisible = true;
button_calculate.IsVisible = true;
resultLabel.IsVisible = true;
prismLengthLabel.IsVisible = false;
prismLengthEntry.IsVisible = false;
cubeSideLabel.IsVisible = false;
cubeSideEntry.IsVisible = false;
prismWidthLabel.IsVisible = false;
prismWidthEntry.IsVisible = false;
prismHeightLabel.IsVisible = false;
prismHeightEntry.IsVisible = false;
cylinderRadiusLabel.IsVisible = false;
cylinderRadiusEntry.IsVisible = false;
cylinderHeightLabel.IsVisible = false;
cylinderHeightEntry.IsVisible = false;
cylinderRadiusLabel.IsVisible = false;
cylinderRadiusEntry.IsVisible = false;
cylinderHeightLabel.IsVisible = false;
cylinderHeightEntry.IsVisible = false;
sphereRadiusLabel.IsVisible = true;
sphereRadiusEntry.IsVisible = true;
coneRadiusLabel.IsVisible = false;
coneRadiusEntry.IsVisible = false;
coneHeightLabel.IsVisible = false;
coneHeightEntry.IsVisible = false;
}
private void Kerucut_Clicked(object sender, EventArgs e) {
    mode = 5;
cubeSideEntry.IsVisible = false;
button_kubus.IsVisible = false;
button_balok.IsVisible = false;
button_tabung.IsVisible = false;
button_bola.IsVisible = false;
button_kerucut.IsVisible = false;
button_back.IsVisible = true;
button_calculate.IsVisible = true;
resultLabel.IsVisible = true;
prismLengthLabel.IsVisible = false;
prismLengthEntry.IsVisible = false;
cubeSideLabel.IsVisible = false;
cubeSideEntry.IsVisible = false;
prismWidthLabel.IsVisible = false;
prismWidthEntry.IsVisible = false;
prismHeightLabel.IsVisible = false;
prismHeightEntry.IsVisible = false;
cylinderRadiusLabel.IsVisible = false;
cylinderRadiusEntry.IsVisible = false;
cylinderHeightLabel.IsVisible = false;
cylinderHeightEntry.IsVisible = false;
sphereRadiusLabel.IsVisible = false;
sphereRadiusEntry.IsVisible = false;
coneRadiusLabel.IsVisible = true;
coneRadiusEntry.IsVisible = true;
coneHeightLabel.IsVisible = true;
coneHeightEntry.IsVisible = true;
}
private void Back_Clicked(object sender, EventArgs e) {
    mode = -1;
cubeSideEntry.IsVisible = true;
button_kubus.IsVisible = true;
button_balok.IsVisible = true;
button_tabung.IsVisible = true;
button_bola.IsVisible = true;
button_kerucut.IsVisible = true;
button_back.IsVisible = false;
button_calculate.IsVisible = false;
resultLabel.IsVisible = false;
prismLengthLabel.IsVisible = false;
prismLengthEntry.IsVisible = false;
cubeSideLabel.IsVisible = false;
cubeSideEntry.IsVisible = false;
prismWidthLabel.IsVisible = false;
prismWidthEntry.IsVisible = false;
prismHeightLabel.IsVisible = false;
prismHeightEntry.IsVisible = false;
cylinderRadiusLabel.IsVisible = false;
cylinderRadiusEntry.IsVisible = false;
cylinderHeightLabel.IsVisible = false;
cylinderHeightEntry.IsVisible = false;
sphereRadiusLabel.IsVisible = false;
sphereRadiusEntry.IsVisible = false;
coneRadiusLabel.IsVisible = false;
coneRadiusEntry.IsVisible = false;
coneHeightLabel.IsVisible = false;
coneHeightEntry.IsVisible = false;
ResetResults();
}
private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            // Check which shape is selected and perform corresponding calculations
            if (mode == 1)
            {
                if (!string.IsNullOrWhiteSpace(cubeSideEntry.Text)) {
                CalculateCube();
                }
            }
            else if (mode == 2)
            {
                if (!string.IsNullOrWhiteSpace(prismLengthEntry.Text) &&
                     !string.IsNullOrWhiteSpace(prismWidthEntry.Text) &&
                     !string.IsNullOrWhiteSpace(prismHeightEntry.Text)) {
                CalculateRectangularPrism();

                     }
            }
            else if (mode == 3)
            {
                if (!string.IsNullOrWhiteSpace(cylinderRadiusEntry.Text) &&
                     !string.IsNullOrWhiteSpace(cylinderHeightEntry.Text)) {
                CalculateCylinder();

                     }
            }
            else if (mode == 4)
            {
                if (!string.IsNullOrWhiteSpace(sphereRadiusEntry.Text)) {
                CalculateSphere();

                }
            }
            else if (mode == 5)
            {
                if (!string.IsNullOrWhiteSpace(coneRadiusEntry.Text) &&
                     !string.IsNullOrWhiteSpace(coneHeightEntry.Text)) {
                CalculateCone();

                     }
            }
            else
            {
                DisplayAlert("Error", "Please enter valid input.", "OK");
            }
        }

        private void CalculateCube()
        {
            if (!double.TryParse(cubeSideEntry.Text, out double side))
            {
                DisplayAlert("Error", "Invalid input for side length.", "OK");
                return;
            }

            double volume = Math.Pow(side, 3);
            double surfaceArea = 6 * Math.Pow(side, 2);

            DisplayResults(volume, surfaceArea);
        }

        private void CalculateRectangularPrism()
        {
            if (!double.TryParse(prismLengthEntry.Text, out double length) ||
                !double.TryParse(prismWidthEntry.Text, out double width) ||
                !double.TryParse(prismHeightEntry.Text, out double height))
            {
                DisplayAlert("Error", "Invalid input for length, width, or height.", "OK");
                return;
            }

            double volume = length * width * height;
            double surfaceArea = 2 * (length * width + length * height + width * height);

            DisplayResults(volume, surfaceArea);
        }

        private void CalculateCylinder()
        {
            if (!double.TryParse(cylinderRadiusEntry.Text, out double radius) ||
                !double.TryParse(cylinderHeightEntry.Text, out double height))
            {
                DisplayAlert("Error", "Invalid input for radius or height.", "OK");
                return;
            }

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            double surfaceArea = 2 * Math.PI * radius * (radius + height);

            DisplayResults(volume, surfaceArea);
        }

        private void CalculateSphere()
        {
            if (!double.TryParse(sphereRadiusEntry.Text, out double radius))
            {
                DisplayAlert("Error", "Invalid input for radius.", "OK");
                return;
            }

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);

            DisplayResults(volume, surfaceArea);
        }

        private void CalculateCone()
        {
            if (!double.TryParse(coneRadiusEntry.Text, out double radius) ||
                !double.TryParse(coneHeightEntry.Text, out double height))
            {
                DisplayAlert("Error", "Invalid input for radius or height.", "OK");
                return;
            }

            double volume = (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
            double surfaceArea = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));

            DisplayResults(volume, surfaceArea);
        }

        private void DisplayResults(double volume, double surfaceArea)
        {
            resultLabel.Text = $"Hasil: \nVolume: {volume:F2}\nLuas Permukaan: {surfaceArea:F2}";
        }
        private void ResetResults()
        {
            resultLabel.Text = "";
        }
}

