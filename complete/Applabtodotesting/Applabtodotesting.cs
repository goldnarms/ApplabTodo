using System;

using Xamarin.Forms;
using Applabtodotesting.Core;

namespace Applabtodotesting
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new TodoList());

		}

		static IDataService database;
		public static IDataService Database {
			get { 
				if (database == null) {
					var connectionResolver = DependencyService.Get<IConnectionResolver> ();
					var connection = connectionResolver.ResolveConnection ();
					database = new DataService (connection);
				}
				return database; 
			}
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

