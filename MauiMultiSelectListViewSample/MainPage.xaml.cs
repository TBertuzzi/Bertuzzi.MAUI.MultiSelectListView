using MauiMultiSelectListViewSample.ViewModel;

namespace MauiMultiSelectListViewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainViewModel();
        }
    }
}