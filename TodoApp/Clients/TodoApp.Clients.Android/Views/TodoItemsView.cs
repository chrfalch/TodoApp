using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace TodoApp.Clients.Android.Views
{
	[Activity(Label = "TodoItems")]
    public class TodoItemsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			SetContentView(Resource.Layout.TodoItemsView);
        }
    }
}