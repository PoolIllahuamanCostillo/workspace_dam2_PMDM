namespace App_IMC.Pages;

public partial class CalculadoraPage : ContentPage
{
	public CalculadoraPage()
	{
		InitializeComponent();
	}

    private void CalculadoraBtn_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(PesoEntry.Text, out double peso) &&
            double.TryParse(AlturaEntry.Text, out double altura))
        {
            double imc = peso / (altura * altura);
            
            
            if(imc < 18.5)
                {
                    ResultadoLabel.Text = $"Tu IMC es: {imc:F2}";
                    ResultadoImagen.Source = "delgado.jpeg";
                }
            else if(imc >= 18.5 && imc <= 24.9)
                {
                    ResultadoLabel.Text = $"Tu IMC es: {imc:F2}";
                    ResultadoImagen.Source = "normal.jpeg";
                }
            else if(imc >= 25 && imc <= 29.9)
                {
                    ResultadoLabel.Text = $"Tu IMC es: {imc:F2}";
                    ResultadoImagen.Source = "sobrepeso.jpeg";
                }
            else
                {
                    ResultadoLabel.Text = $"Tu IMC es: {imc:F2}";
                    ResultadoImagen.Source = "obesidad.jpeg";
                }
        }

            else
        {
            ResultadoLabel.Text = "Introduce valores válidos";
        }
    }
}