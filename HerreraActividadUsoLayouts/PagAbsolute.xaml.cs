namespace HerreraActividadUsoLayouts;

public partial class PagAbsolute : ContentPage
{
	public PagAbsolute()
	{
		InitializeComponent();
	}

    private void IrAlMenuGridPage_clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PagGrid());
    }
}