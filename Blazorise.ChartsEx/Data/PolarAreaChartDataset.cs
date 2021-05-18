using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  /// <remarks>
  /// Defaults as per https://www.chartjs.org/docs/latest/charts/polar.html#dataset-properties
  /// </remarks>
  [DataContract]
  public class PolarAreaChartDataset<T> : ChartDataset<T>
  {
    public PolarAreaChartDataset() : base(
      label: string.Empty,
      backgroundColor: new List<string> { ChartColor.FromRgba( 0, 0, 0, 0.1f ) },
      borderColor: new List<string> { ChartColor.FromRgba( 0xF, 0xF, 0xF, 1.0f ) },
      borderWidth: 2
    )
    {
      Type = "polarArea";
    }

    /// <summary>
    /// The fill colour of the arcs when hovered.
    /// </summary>
    /// <remarks>Default as per https://www.chartjs.org/docs/latest/configuration/elements.html#arc-configuration </remarks>
    [DataMember( EmitDefaultValue = false )]
    [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
    [JsonConverter( typeof( IndexableOptionsConverter<object> ) )]
    public IndexableOption<object> HoverBackgroundColor { get; set; }

    /// <summary>
    /// The stroke colour of the arcs when hovered.
    /// </summary>
    /// <remarks>Default as per https://www.chartjs.org/docs/latest/configuration/elements.html#arc-configuration </remarks>
    [DataMember( EmitDefaultValue = false )]
    [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
    [JsonConverter( typeof( IndexableOptionsConverter<object> ) )]
    public IndexableOption<object> HoverBorderColor { get; set; }

    /// <summary>
    /// The stroke width of the arcs when hovered.
    /// </summary>
    /// <remarks>Default as per https://www.chartjs.org/docs/latest/configuration/elements.html#arc-configuration </remarks>
    [DataMember]
    public int HoverBorderWidth { get; set; }
  }
}
