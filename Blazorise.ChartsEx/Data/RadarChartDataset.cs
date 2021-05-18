using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  /// <remarks>
  /// Defaults from https://www.chartjs.org/docs/latest/charts/radar.html#dataset-properties
  /// </remarks>
  [DataContract]
  public class RadarChartDataset<T> : ChartDataset<T>
  {
    public RadarChartDataset() : base(
      label: string.Empty,
      backgroundColor: new List<string> { ChartColor.FromRgba( 0, 0, 0, 0.1f ) },
      borderColor: new List<string> { ChartColor.FromRgba( 0, 0, 0, 0.1f ) },
      borderWidth: 3
    )
    {
      Type = "radar";
    }

    /// <summary>
    /// How to fill the area under the line.
    /// </summary>
    [DataMember]
    public bool Fill { get; set; } = true;

    /// <summary>
    /// Bezier curve tension of the line. Set to 0 to draw straightlines.
    /// </summary>
    [DataMember]
    public float LineTension { get; set; } = 0.4f;
  }
}
