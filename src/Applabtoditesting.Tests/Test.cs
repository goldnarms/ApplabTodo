using NUnit.Framework;
using System;
using Applabtodotesting.Core;
using System.Linq;

namespace Applabtoditesting.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
		}

		[Test]
		public void Adding_A_TodoItem_Should_Increase_Total_Todo_Items_With_One()
		{
			// Bruke _dataService til å finne count før save/add og sammenlign med ny count
			var dataService = new FakeDataService();
			var oldCount = dataService.GetAll ().Count ();
			dataService.Create (new TodoItem{ Title = "Test" });
			var newCount = dataService.GetAll ().Count ();
			Assert.AreEqual (oldCount + 1, newCount);
		}
	}
}

