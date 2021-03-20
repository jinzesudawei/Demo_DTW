using Demo_DTW.Views;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo_DTW.ViewModels
{
	public class SiteSelectionViewModel : BaseViewModel
	{
		public SiteSelectionViewModel()
		{
			上传记录Command = new Command(async () => await Execute上传记录Command());
			物流跟踪Command = new Command(async () => await Execute物流跟踪Command());
			扫描记录Command = new Command(async () => await Execute扫描记录Command());
		}

		public Command 上传记录Command { get; }
		async Task Execute上传记录Command()
		{
			await Shell.Current.GoToAsync($"//{nameof(进站IP_上传记录_Page)}");
		}

		public Command 物流跟踪Command { get; }
		async Task Execute物流跟踪Command()
		{
			await Shell.Current.GoToAsync($"//{nameof(进站IP_物流跟踪_Page)}");
		}

		public Command 扫描记录Command { get; }
		async Task Execute扫描记录Command()
		{
			await Shell.Current.GoToAsync($"//{nameof(进站IP_扫描记录_Page)}");
		}
	}
}