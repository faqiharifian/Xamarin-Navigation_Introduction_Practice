﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Modul4_Practice
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new Modul4_Practice.MainPage();
            //MainPage = new NavigationPage(new NavigationPage1());
            MainPage = new DropdownMenu();
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
