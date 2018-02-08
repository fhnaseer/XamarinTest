using System.Collections.Generic;
using Xamarin.Forms.Maps;

namespace TestApp.Model
{
    public static class FakeData
    {
        public static Position GetStartingPosition()
        {
            return new Position(48.137462, 11.575472);
        }

        public static List<GeoJson> GetFieldCoordinates()
        {
            var positionOne = new GeoJson();
            positionOne.Geometry.Coordinates[0] = 48.137508;
            positionOne.Geometry.Coordinates[1] = 11.574123;
            var positionTwo = new GeoJson();
            positionTwo.Geometry.Coordinates[0] = 48.137343;
            positionTwo.Geometry.Coordinates[1] = 11.574783;
            var positionThree = new GeoJson();
            positionThree.Geometry.Coordinates[0] = 48.137569;
            positionThree.Geometry.Coordinates[1] = 11.574912;
            var positionFour = new GeoJson();
            positionFour.Geometry.Coordinates[0] = 48.137744;
            positionFour.Geometry.Coordinates[1] = 11.574306;

            return new List<GeoJson> { positionOne, positionTwo, positionThree, positionFour };
        }
    }
}
