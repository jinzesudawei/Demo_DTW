﻿using Demo_DTW.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo_DTW.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			this.BindingContext = new LoginViewModel();
		}
	}
}