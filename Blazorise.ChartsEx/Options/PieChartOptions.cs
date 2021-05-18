using System;
using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class PieChartOptions : ChartOptions
  {
    /// <summary>
    /// The percentage of the chart that is cut out of the middle.
    /// </summary>
    [DataMember]
    public int CutoutPercentage { get; set; } = 0;

    /// <summary>
    /// Starting angle to draw arcs from.
    /// </summary>
    [DataMember]
    public double Rotation { get; set; } = -0.5 * Math.PI;

    /// <summary>
    /// Sweep to allow arcs to cover.
    /// </summary>
    [DataMember]
    public double Circumference { get; set; } = 2 * Math.PI;
  }
}
