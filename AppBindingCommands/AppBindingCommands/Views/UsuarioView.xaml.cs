using AppBindingCommands.ViewModel;

namespace AppBindingCommands.Views;

public partial class UsuarioView : ContentPage
{
	public UsuarioView()
	{
		InitializeComponent();

		BindingContext = new UsuarioViewModel();
	}
}