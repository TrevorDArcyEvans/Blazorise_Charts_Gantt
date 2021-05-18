using System;
using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class PolarAreaChartOptions : ChartOptions
  {
    /// <summary>
    /// Starting angle to draw arcs for the first item in a dataset.
    /// </summary>
    [DataMember]
    public double StartAngle { get; set; } = -0.5 * Math.PI;
  }
}
