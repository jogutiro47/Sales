﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Sales
{
    using Views;
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //La aplicacion va a Iniciar por ProdutsPage
            MainPage = new ProductsPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
