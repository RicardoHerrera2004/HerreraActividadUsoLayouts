namespace HerreraActividadUsoLayouts;

public partial class PagGrid : ContentPage
{
	public PagGrid()
	{
		InitializeComponent();
	}

	private void VolverPaginaPri_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PagStack());
    }
}