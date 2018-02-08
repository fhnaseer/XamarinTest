using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TestApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(Map map)
        {
            _map = map;
            _map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromMiles(1)));
        }

        private readonly Map _map;


        private ICommand _streetViewCommand;
        public ICommand StreetViewCommand => _streetViewCommand ?? (_streetViewCommand = new Command(StreetView));

        internal void StreetView()
        {
            _map.MapType = MapType.Street;
        }

        private ICommand _hybridViewCommand;
        public ICommand HybridViewCommand => _hybridViewCommand ?? (_hybridViewCommand = new Command(HybridView));

        internal void HybridView()
        {
            _map.MapType = MapType.Hybrid;
        }

        private ICommand _satelliteViewCommand;
        public ICommand SatelliteViewCommand => _satelliteViewCommand ?? (_satelliteViewCommand = new Command(SatelliteView));

        internal void SatelliteView()
        {
            _map.MapType = MapType.Satellite;
        }
    }
}
