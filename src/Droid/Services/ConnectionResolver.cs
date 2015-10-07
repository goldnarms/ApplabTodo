using System;
using Applabtodotesting.Core;
using SQLite.Net;
using System.IO;

[assembly:Xamarin.Forms.Dependency(typeof(Applabtodotesting.Droid.ConnectionResolver))]
namespace Applabtodotesting.Droid
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

