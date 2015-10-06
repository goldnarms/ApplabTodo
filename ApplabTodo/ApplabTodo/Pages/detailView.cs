using System;

using Xamarin.Forms;

namespace ApplabTodo
{
	public class TaskDetailPage : ContentPage
	{
		public TaskDetailPage (Task task)
		{
			var titleLabel = new Label () {
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
			};

			var descriptionLabel = new Label{
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
			};
			Children.Add (titleLabel);
			Children.Add (descriptionLabel);
		}
	}
}


