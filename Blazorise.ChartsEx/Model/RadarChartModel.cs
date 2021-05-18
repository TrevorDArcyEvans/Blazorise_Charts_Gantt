using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class RadarChartModel : ChartModel
  {
    [JsonPropertyName( "label" )]
    public string Label { get; set; }

    [JsonPropertyName( "backgroundColor" )]
    public string BackgroundColor { get; set; }

    [JsonPropertyName( "borderColor" )]
    public string BorderColor { get; set; }

    [JsonPropertyName( "borderWidth" )]
    public double BorderWidth { get; set; }

    [JsonPropertyName( "controlPointNextX" )]
    public double ControlPointNextX { get; set; }

    [JsonPropertyName( "controlPointNextY" )]
    public double ControlPointNextY { get; set; }

    [JsonPropertyName( "controlPointPreviousX" )]
    public double ControlPointPreviousX { get; set; }

    [JsonPropertyName( "controlPointPreviousY" )]
    public double ControlPointPreviousY { get; set; }

    [JsonPropertyName( "hitRadius" )]
    public double HitRadius { get; set; }

    [JsonPropertyName( "pointStyle" )]
    public string PointStyle { get; set; }

    [JsonPropertyName( "radius" )]
    public double Radius { get; set; }

    [JsonPropertyName( "skip" )]
    public bool Skip { get; set; }

    [JsonPropertyName( "tension" )]
    public double Tension { get; set; }

    //[JsonPropertyName( "x" )]
    //public double X { get; set; }

    //[JsonPropertyName( "y" )]
    //public double Y { get; set; }
  }
}
