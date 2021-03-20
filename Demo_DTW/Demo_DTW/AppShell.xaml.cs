using Demo_DTW.Views;
using System;
using Xamarin.Forms;

namespace Demo_DTW
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));

			Routing.RegisterRoute(nameof(进站IP_上传记录_Page), typeof(进站IP_上传记录_Page));
			Routing.RegisterRoute(nameof(进站IP_扫描记录_Page), typeof(进站IP_扫描记录_Page));
			Routing.RegisterRoute(nameof(进站IP_物流跟踪_Page), typeof(进站IP_物流跟踪_Page));
		}

		private async void OnMenuItemClicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//LoginPage");
		}
	}
}
