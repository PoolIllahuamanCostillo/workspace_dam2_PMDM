namespace App_IMC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MenuBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.CalculadoraPage());
        }

       
    }
    
}
