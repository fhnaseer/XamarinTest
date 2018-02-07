using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TestApp
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(37, -122), Distance.FromMiles(1)));
            MyMap.VerticalOptions = LayoutOptions.FillAndExpand;
            MyMap.MapType = MapType.Street;
        }
    }
}
