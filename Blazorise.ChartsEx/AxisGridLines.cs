using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  /// <summary>
  /// The grid line configuration is nested under the scale configuration in the gridLines key. It defines options for the grid lines that run perpendicular to the axis.
  /// </summary>
  [DataContract]
  public class AxisGridLines
  {
    /// <summary>
    /// If false, do not display grid lines for this axis.
    /// </summary>
    [DataMember]
    public bool Display { get; set; } = true;

    /// <summary>
    /// If true, gridlines are circular (on radar chart only).
    /// </summary>
    [DataMember]
    public bool Circular { get; set; }

    /// <summary>
    /// The color of the grid lines.
    /// </summary>
    [DataMember]
    public string Color { get; set; }

    /// <summary>
    /// Length and spacing of dashes on grid lines
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    public List<int> BorderDash { get; set; }

    /// <summary>
    /// Offset for line dashes.
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    public decimal BorderDashOffset { get; set; } = 0m;

    /// <summary>
    /// Stroke width of grid lines.
    /// </summary>
    [DataMember]
    public int LineWidth { get; set; } = 1;

    /// <summary>
    /// If true, draw border at the edge between the axis and the chart area.
    /// </summary>
    [DataMember]
    public bool DrawBorder { get; set; } = true;

    /// <summary>
    /// If true, draw lines on the chart area inside the axis lines. This is useful when there are multiple axes and you need to control which grid lines are drawn.
    /// </summary>
    [DataMember]
    public bool DrawOnChartArea { get; set; } = true;

    /// <summary>
    /// If true, draw lines beside the ticks in the axis area beside the chart.
    /// </summary>
    [DataMember]
    public bool DrawTicks { get; set; } = true;

    /// <summary>
    /// Length in pixels that the grid lines will draw into the axis area.
    /// </summary>
    [DataMember]
    public int TickMarkLength { get; set; } = 10;

    /// <summary>
    /// Stroke width of the grid line for the first index (index 0).
    /// </summary>
    [DataMember]
    public int ZeroLineWidth { get; set; } = 1;

    /// <summary>
    /// Stroke color of the grid line for the first index (index 0).
    /// </summary>
    [DataMember]
    public string ZeroLineColor { get; set; }

    /// <summary>
    /// Length and spacing of dashes of the grid line for the first index (index 0).
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    public List<int> ZeroLineBorderDash { get; set; }

    /// <summary>
    /// Offset for line dashes of the grid line for the first index (index 0).
    /// </summary>
    [DataMember]
    public decimal ZeroLineBorderDashOffset { get; set; } = 0m;

    /// <summary>
    /// If true, grid lines will be shifted to be between labels. This is set to true for a category scale in a bar chart by default.
    /// </summary>
    [DataMember]
    public bool OffsetGridLines { get; set; }
  }
}
