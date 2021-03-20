using Demo_DTW.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_DTW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SiteSelectionPage : ContentPage
	{
		public SiteSelectionPage()
		{
			InitializeComponent();
			this.BindingContext = new SiteSelectionViewModel();
		}
	}
}