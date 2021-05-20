using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class DoughnutChartOptions : PieChartOptions
  {
    /// <summary>
    /// The percentage of the chart that is cut out of the middle.
    /// </summary>
    [DataMember]
    public new int CutoutPercentage { get; set; } = 50;
  }
}
