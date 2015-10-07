using System;

using Xamarin.Forms;
using Applabtodotesting.Core;
using System.Threading.Tasks;
using Acr.UserDialogs;
using System.Linq;

namespace Applabtodotesting
{
	public class TodoList : ContentPage
	{
		private IDataService _dataService;
		private ListView _listView;
		public TodoList ()
		{
			_dataService = App.Database;
			var todoItems = _dataService.GetAll ();
			_listView = new ListView ();
			_listView.ItemsSource = todoItems;
			_listView.ItemTemplate = new DataTemplate (typeof(TodoItemViewCell));
			_listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
				if(e.SelectedItem == null)
					return;
				var todoItem = e.SelectedItem as TodoItem;
				_listView.SelectedItem = null;
				var detailView = new TodoDetail(todoItem);
				Navigation.PushAsync(detailView);
			};

			Content = new StackLayout { 
				Children = {
					_listView
				},
					Padding = new Thickness(10, Device.OnPlatform(20, 0, 0))
			};

			Title = "Todo";

			ToolbarItems.Add (new ToolbarItem {
				Text = "Legg til",
				Order = ToolbarItemOrder.Primary,
				Command = new Command(async () => await AddTodoPopup())
			});
		}

		async Task AddTodoPopup(){
			var status = await UserDialogs.Instance.PromptAsync(new PromptConfig {
				Title = "Legg til todo",
				Text = "",
				IsCancellable = true,
				OkText = "Lagre"
			});

			var todoItem = new TodoItem();
			//todoItem. = DateTime.UtcNow;
			todoItem.Title = status.Text;
			_dataService.Create (todoItem);
			var todoItems = _dataService.GetAll ();
			_listView.ItemsSource = todoItems.ToList ();
		}
	}
}