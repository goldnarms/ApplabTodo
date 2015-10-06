using System;
using NUnit.Framework;

namespace Fixtures {

	[TestFixture]
	public class Tests {
		IDataService _dataService;
		public DataServiceTest ()
		{

		}

		[Test]
		public void Adding_A_TodoItem_Should_Increase_Total_Todo_Items_With_One()
		{
			// Bruke _dataService til å finne count før save/add og sammenlign med ny count

			Assert.Equal(oldCount + 1, newCount);
		}
	}
}

