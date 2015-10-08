using System;
using SQLite.Net;

namespace Applabtodotesting.Core
{
	public interface IConnectionResolver
	{
		SQLiteConnection ResolveConnection();
	}
}

