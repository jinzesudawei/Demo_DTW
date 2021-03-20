using Demo_DTW.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Demo_DTW.ViewModels
{
	public class 上传记录ViewModel : BaseViewModel
	{
		public ObservableCollection<上传记录> SiteSelectionList { get; }

		public 上传记录ViewModel()
		{
			SiteSelectionList = new ObservableCollection<上传记录>
			{
				new 上传记录 { ID = 1, Name = "Name1" },
				new 上传记录 { ID = 2, Name = "Name2" },
				new 上传记录 { ID = 3, Name = "Name3" },
				new 上传记录 { ID = 4, Name = "Name4" },
				new 上传记录 { ID = 5, Name = "Name5" }
			};
		}

		public Command SiteSelectCommand { get; }
	}
}