using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  /// <remarks>
  /// Defaults values as per https://www.chartjs.org/docs/latest/charts/line.html#dataset-properties
  /// </remarks>
  [DataContract]
  public class LineChartDataset<T> : ChartDataset<T>
  {
    public LineChartDataset() : base(
      label: string.Empty,
      backgroundColor: new List<string> { ChartColor.FromRgba( 0, 0, 0, 0.1f ) },
      borderColor: new List<string> { ChartColor.FromRgba( 0, 0, 0, 0.1f ) },
      borderWidth: 3
    )
    {
      Type = "line";
    }

    /// <summary>
    /// Length and spacing of dashes.
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    public List<int> BorderDash { get; set; } = new List<int>();

    /// <summary>
    /// Offset for line dashes.
    /// </summary>
    [DataMember]
    public float BorderDashOffset { get; set; }

    /// <summary>
    /// Fill the area under the line.
    /// </summary>
    [DataMember]
    public bool Fill { get; set; } = true;

    /// <summary>
    /// Bezier curve tension of the line. Set to 0f to draw straightlines. This option is ignored if monotone cubic interpolation is used.
    /// </summary>
    [DataMember]
    public float LineTension { get; set; } = 0.4f;

    /// <summary>
    /// The fill color for points.
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
    [JsonConverter( typeof( IndexableOptionsConverter<object> ) )]
    public IndexableOption<object> PointBackgroundColor { get; set; }

    /// <summary>
    /// The border color for points.
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
    [JsonConverter( typeof( IndexableOptionsConverter<object> ) )]
    public IndexableOption<object> PointBorderColor { get; set; }

    /// <summary>
    /// The width of the point border in pixels.
    /// </summary>
    [DataMember]
    public int PointBorderWidth { get; set; } = 1;

    /// <summary>
    /// The radius of the point shape. If set to 0, the point is not rendered.
    /// </summary>
    [DataMember]
    public float PointRadius { get; set; } = 3.0f;

    /// <summary>
    /// If false, the line is not drawn for this dataset.
    /// </summary>
    [DataMember]
    public bool ShowLine { get; set; } = true;

    /// <summary>
    /// If true, lines will be drawn between points with no or null data. If false, points with NaN data will create a break in the line.
    /// </summary>
    [DataMember]
    public bool SpanGaps { get; set; }

    /// <summary>
    /// If the line is shown as a stepped line.
    /// </summary>
    [DataMember]
    public bool SteppedLine { get; set; }

    /// <summary>
    /// https://www.chartjs.org/docs/latest/charts/line.html#cubicinterpolationmode
    /// </summary>
    [DataMember]
    public string CubicInterpolationMode { get; set; } = "default";
  }
}
