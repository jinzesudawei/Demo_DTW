using Demo_DTW.ViewModels;
using Xamarin.Forms;

namespace Demo_DTW.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}