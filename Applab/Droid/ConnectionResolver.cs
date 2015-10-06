
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly:Xamarin.Forms.Dependency(typeof(ApplabTodo.Droid.ConnectionResolver))]
namespace ApplabTodo.Droid
{
	public class ConnectionResolver : IConnectionResolver
	{
		public ConnectionResolver ()
		{
		}

		public SQLiteConnection ResolveConnection ()
		{
			var path = Path.Combine (
				Environment.GetFolderPath (Environment.SpecialFolder.Personal),
				"tasks.db");
			return new SQLiteConnection(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), 
				path);
		}
	}
}

