namespace HerreraActividadUsoLayouts;

public partial class PagFlex : ContentPage
{
	public PagFlex()
	{
		InitializeComponent();
	}

    private void IrAlMenuAbsolutePage_clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PagAbsolute());
    }
}