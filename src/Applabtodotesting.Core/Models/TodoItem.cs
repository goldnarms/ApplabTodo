using System;
using SQLite.Net.Attributes;

namespace Applabtodotesting.Core
{
	[Table("TodoItem")]
	public class TodoItem
	{
		[PrimaryKey, AutoIncrement]
			public int Id {
				get;
				set;
			}

			public bool IsCompleted {
				get;
				set;
			}

			public string Description {
				get;
				set;
			}

			public string Title {
				get;
				set;
		}
	}
}

