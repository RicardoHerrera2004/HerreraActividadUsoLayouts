namespace HerreraActividadUsoLayouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void IrPaginaGrid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagGrid());
        }

        private void IrPaginaStack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagStack());
        }

        private void IrPaginaFlex_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagFlex());
        }

        private void IrPaginaAbsolute_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PagAbsolute());
        }
    }

}
