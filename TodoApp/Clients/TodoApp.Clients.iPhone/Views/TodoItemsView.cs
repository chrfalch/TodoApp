using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using TodoApp.Clients.Core.ViewModels;

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
			   
            var label = new UILabel(new RectangleF(10, 10, 300, 40));
            Add(label);
            var textField = new UITextField(new RectangleF(10, 50, 300, 40));
            Add(textField);

			var set = this.CreateBindingSet<TodoItemsView, TodoItemsViewModel>();
			set.Bind(label).To(vm => vm.NewTodoItemText);
			set.Bind(textField).To(vm => vm.NewTodoItemText);
            set.Apply();
        }
    }
}