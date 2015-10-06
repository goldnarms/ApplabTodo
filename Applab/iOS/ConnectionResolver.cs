[assembly:Xamarin.Forms.Dependency(typeof(ApplabTodo.iOS.ConnectionResolver))]
namespace ApplabTodo.iOS
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