﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  /// <remarks>
  /// Defaults as per https://www.npmjs.com/package/chartjs-plugin-gantt
  /// </remarks>
  [DataContract]
  public class GanttChartDataset<T> : ChartDataset<T>
  {
    public GanttChartDataset() : base(
      label: string.Empty,
      backgroundColor: new List<string> { ChartColor.FromRgba(0, 0, 0, 0.1f) },
      borderColor: new List<string> { ChartColor.FromRgba(0, 0, 0, 0.1f) },
      borderWidth: 0
    )
    {
      Type = "gantt";
    }

    /// <summary>
    /// The fill colour of the bars when hovered.
    /// </summary>
    /// <remarks>Default as per https://www.chartjs.org/docs/latest/configuration/elements.html#rectangle-configuration </remarks>
    [DataMember(EmitDefaultValue = false)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(IndexableOptionsConverter<object>))]
    public IndexableOption<object> HoverBackgroundColor { get; set; }

    /// <summary>
    /// The stroke colour of the bars when hovered.
    /// </summary>
    /// <remarks>Default as per https://www.chartjs.org/docs/latest/configuration/elements.html#rectangle-configuration </remarks>
    [DataMember(EmitDefaultValue = false)]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(IndexableOptionsConverter<object>))]
    public IndexableOption<object> HoverBorderColor { get; set; }

    /// <summary>
    /// The stroke width of the bars when hovered.
    /// </summary>
    [DataMember]
    public int HoverBorderWidth { get; set; } = 1;

    [DataMember]
    public double Height { get; set; } = 0.125f;
  }
}
