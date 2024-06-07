namespace MeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_compensa_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string msg = "";
                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol esta compensndo mais";
                }
                else 
                {
                    msg = "A gasolina esta compensando mais";
                }

                DisplayAlert("Calculado", msg, "OK");

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "Fechar");
            }
        }
    }

}
