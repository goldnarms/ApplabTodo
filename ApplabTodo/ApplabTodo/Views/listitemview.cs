using System;
using Xamarin.Forms;

namespace ApplabTodo
{
	public class listitemview: ViewCell
	{
		public listitemview(TodoItem item){
			var title = new Label { Text = item.Title };

			var layout = new StackLayout { Orientation = StackOrientation.Horizontal };
			layout.Children.Add (title);
			this.View = layout;
		}
		
	}
}
	