using System.Windows.Input;
using TestApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace TestApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(CustomMap map)
        {
            _map = map;

            var points = FakeData.GetFieldCoordinates();
            foreach (var point in points)
                _map.ShapeCoordinates.Add(new Position(point.Geometry.Coordinates[0], point.Geometry.Coordinates[1]));
            _map.MoveToRegion(MapSpan.FromCenterAndRadius(FakeData.GetStartingPosition(), Distance.FromMiles(0.1)));
        }

        private readonly CustomMap _map;


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
