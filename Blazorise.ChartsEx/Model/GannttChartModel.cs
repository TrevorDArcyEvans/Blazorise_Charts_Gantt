using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
    [DataContract]
    public class GannttChartModel : ChartModel
    {
        [JsonPropertyName( "label" )]
        public string Label { get; set; }

        [JsonPropertyName( "datasetLabel" )]
        public string DatasetLabel { get; set; }

        [JsonPropertyName( "backgroundColor" )]
        public string BackgroundColor { get; set; }

        [JsonPropertyName( "borderColor" )]
        public string BorderColor { get; set; }

        [JsonPropertyName( "borderWidth" )]
        public double BorderWidth { get; set; }

        [JsonPropertyName( "borderSkipped" )]
        public string BorderSkipped { get; set; }

        [JsonPropertyName( "base" )]
        public double Base { get; set; }

        [JsonPropertyName( "horizontal" )]
        public bool Horizontal { get; set; }

        //[JsonPropertyName( "x" )]
        //public double X { get; set; }

        //[JsonPropertyName( "y" )]
        //public double Y { get; set; }

        [JsonPropertyName( "width" )]
        public double Width { get; set; }
    }
}