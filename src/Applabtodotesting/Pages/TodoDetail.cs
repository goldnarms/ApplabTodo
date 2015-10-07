using System;

using Xamarin.Forms;
using Applabtodotesting.Core;

namespace Applabtodotesting
{
	public class TodoDetail : ContentPage
	{
		public TodoDetail (TodoItem todoItem)
		{
			BindingContext = todoItem;
			var titleLabel = new Label () {
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				Text = todoItem.Title
			};

			var descriptionLabel = new Label{
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
				Text = todoItem.Description
			};
			Content = new StackLayout { 
				Children = {
					titleLabel,
					descriptionLabel
				},
			};
			Padding = new Thickness (10, Device.OnPlatform (20, 0, 0));

			ToolbarItems.Add (new ToolbarItem {
				Text = todoItem.IsCompleted ? "Gjenåpne" : "Fullfør",
				Order = ToolbarItemOrder.Primary,
				Command = new Command(Complete)
			});

			Title = todoItem.Title;
		}

		void Complete(){
			var dataService = App.Database;
			var todoItem = BindingContext as TodoItem;
			todoItem.IsCompleted = !todoItem.IsCompleted;
			ToolbarItems [0].Text = todoItem.IsCompleted ? "Gjenåpne" : "Fullfør";
			dataService.Update (todoItem);
		}
	}
}


