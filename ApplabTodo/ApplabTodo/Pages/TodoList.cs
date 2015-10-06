using System;

using Xamarin.Forms;

namespace ApplabTodo
{
	public class TodoPage : ContentPage
	{
		public TodoPage (TodoList todolist)
		{
			Children.Add (new ListView());
			Title = "todo-lista";
		}
	}
}



