using System;
using System.Collections.Generic;
using Android.Content;
using Android.Gms.Maps.Model;
using TestApp.Droid;
using TestApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace TestApp.Droid
{
    public class CustomMapRenderer : MapRenderer
    {
        List<Position> _shapeCoordinates;

        public CustomMapRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Unsubscribe
            }

            if (e.NewElement != null)
            {
                var formsMap = (CustomMap)e.NewElement;
                _shapeCoordinates = formsMap.ShapeCoordinates;
                Control.GetMapAsync(this);
            }
        }

        protected override void OnMapReady(Android.Gms.Maps.GoogleMap map)
        {
            base.OnMapReady(map);
            var polygonOptions = new PolygonOptions();
            polygonOptions.InvokeFillColor(0x66FF0000);
            polygonOptions.InvokeStrokeColor(0x660000FF);
            polygonOptions.InvokeStrokeWidth(30.0f);
            foreach (var position in _shapeCoordinates)
                polygonOptions.Add(new LatLng(position.Latitude, position.Longitude));
            try
            {
                NativeMap.AddPolygon(polygonOptions);
            }
            catch (Exception e)
            {
            }

        }
    }
}
