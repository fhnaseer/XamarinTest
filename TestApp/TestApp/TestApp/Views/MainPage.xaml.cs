using TestApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TestApp.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel(MyMap);

        }
    }
}
