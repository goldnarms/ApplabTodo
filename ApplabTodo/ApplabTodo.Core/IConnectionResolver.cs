using System;

namespace ApplabTodo.Core
public interface IConnectionResolver
{
	SQLiteConnection ResolveConnection();
}

