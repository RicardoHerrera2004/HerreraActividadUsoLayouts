namespace HerreraActividadUsoLayouts;

public partial class PagStack : ContentPage
{
	public PagStack()
	{
		InitializeComponent();
	}

    private void IrPaginaFlex_clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PagFlex());
    }
}