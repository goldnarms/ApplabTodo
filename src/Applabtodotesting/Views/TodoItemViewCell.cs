using System;
using Xamarin.Forms;
using Applabtodotesting.Core;

namespace Applabtodotesting
{
	public class TodoItemViewCell : ViewCell
	{
		public TodoItemViewCell ()
		{
			var lblTitle = new Label { };
			lblTitle.SetBinding (Label.TextProperty, "Title");
			var layout = new StackLayout { 
				Orientation = StackOrientation.Horizontal,
				Children = {
					lblTitle
				}
			};

			this.View = layout;
		}
	}
}