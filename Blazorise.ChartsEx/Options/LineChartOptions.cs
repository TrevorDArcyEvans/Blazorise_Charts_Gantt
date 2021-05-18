using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class LineChartOptions : ChartOptions
  {
    /// <summary>
    /// If false, the lines between points are not drawn.
    /// </summary>
    [DataMember]
    public bool ShowLines { get; set; } = true;

    /// <summary>
    /// If false, NaN data causes a break in the line.
    /// </summary>
    [DataMember]
    public bool SpanGaps { get; set; }
  }
}
