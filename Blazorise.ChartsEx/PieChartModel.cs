using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class PieChartModel : ChartModel
  {
    [JsonPropertyName( "label" )]
    public string Label { get; set; }

    [JsonPropertyName( "backgroundColor" )]
    public string BackgroundColor { get; set; }

    [JsonPropertyName( "borderColor" )]
    public string BorderColor { get; set; }

    [JsonPropertyName( "borderWidth" )]
    public double BorderWidth { get; set; }

    [JsonPropertyName( "circumference" )]
    public double Circumference { get; set; }

    [JsonPropertyName( "startAngle" )]
    public double StartAngle { get; set; }

    [JsonPropertyName( "endAngle" )]
    public double EndAngle { get; set; }

    [JsonPropertyName( "outerRadius" )]
    public double OuterRadius { get; set; }

    [JsonPropertyName( "innerRadius" )]
    public double InnerRadius { get; set; }

    //[JsonPropertyName( "x" )]
    //public double X { get; set; }

    //[JsonPropertyName( "y" )]
    //public double Y { get; set; }
  }
}
