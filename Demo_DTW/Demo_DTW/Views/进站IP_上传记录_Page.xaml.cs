using Demo_DTW.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_DTW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class 进站IP_上传记录_Page : ContentPage
	{
		public 进站IP_上传记录_Page()
		{
			InitializeComponent();
			this.BindingContext = new 上传记录ViewModel();
		}
	}
}