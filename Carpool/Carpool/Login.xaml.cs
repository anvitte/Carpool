﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Carpool
{
	public partial class Login : ContentPage
	{
		public Login ()
		{

			InitializeComponent ();
		}

        async void SignIn(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new Dashboard());
            Application.Current.MainPage = new NavigationPage(new Dashboard());

        }
	}
}
