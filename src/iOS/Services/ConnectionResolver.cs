using System;
using SQLite.Net;
using System.IO;
using Applabtodotesting.Core;

[assembly:Xamarin.Forms.Dependency(typeof(Applabtodotesting.iOS.ConnectionResolver))]
namespace Applabtodotesting.iOS
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
			return new SQLiteConnection(new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS(), 
				path);
		}
	}
}

