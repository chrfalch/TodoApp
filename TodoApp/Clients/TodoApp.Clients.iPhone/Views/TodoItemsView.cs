using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using TodoApp.Clients.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.Views;
using TodoApp.Shared.BL.Models;
using System.Windows.Input;

namespace TodoApp.Clients.iPhone.Views
{
    public class TodoItemsView : MvxViewController
    {
        public override void ViewDidLoad()
        {
			View = new UIView(){ BackgroundColor = UIColor.White};
			base.ViewDidLoad();

			// ios7 layout
			if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
				EdgesForExtendedLayout = UIRectEdge.None;

			var textField = new UITextField(new RectangleF(0, 0, 280, 40));
			textField.BorderStyle = UITextBorderStyle.Line;
			Add(textField);

			var button = new UIButton (UIButtonType.RoundedRect);
			button.Frame = new RectangleF (280, 0, 40, 40);
			button.SetTitle ("+", UIControlState.Normal);
			button.TouchUpInside += (object sender, System.EventArgs e) => {
				(ViewModel as TodoItemsViewModel).AddTodoItemCommand.Execute();
			};

			Add (button);

			var tableView = new UITableView(new RectangleF(0, 40, 320, 500), UITableViewStyle.Plain);
			Add(tableView);

			// choice here:
			//
			//   for original demo use:
			//     var source = new MvxStandardTableViewSource(tableView, "TitleText");
			//
			//   or for prettier cells from XIB file use:
			//     tableView.RowHeight = 88;
			//     var source = new MvxSimpleTableViewSource(tableView, BookCell.Key, BookCell.Key);

			tableView.RowHeight = 88;
			var source = new MvxStandardTableViewSource (tableView, "TitleText Text;");
			tableView.Source = source;

			var set = this.CreateBindingSet<TodoItemsView, TodoItemsViewModel>();
			set.Bind(textField).To(vm => vm.NewTodoItemText);
			set.Bind(source).To(vm => vm.Items);
			set.Apply();

			tableView.ReloadData();
        }
    }
}