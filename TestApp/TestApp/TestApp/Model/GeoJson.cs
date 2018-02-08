namespace TestApp.Model
{
    public class GeoJson
    {
        public string Type { get; set; }

        private Geometry _geometry;
        public Geometry Geometry => _geometry ?? (_geometry = new Geometry());

        private Properties _properties;
        public Properties Properties => _properties ?? (_properties = new Properties());
    }

    public class Geometry
    {
        public string Type { get; set; }

        public double[] Coordinates { get; } = { 0.0, 0.0 };
    }

    public class Properties
    {
        public string Name { get; set; }
    }
}
