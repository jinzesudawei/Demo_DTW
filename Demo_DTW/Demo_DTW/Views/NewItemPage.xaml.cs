using Demo_DTW.Models;
using Demo_DTW.ViewModels;
using Xamarin.Forms;

namespace Demo_DTW.Views
{
	public partial class NewItemPage : ContentPage
	{
		public Item Item { get; set; }

		public NewItemPage()
		{
			InitializeComponent();
			BindingContext = new NewItemViewModel();
		}
	}
}