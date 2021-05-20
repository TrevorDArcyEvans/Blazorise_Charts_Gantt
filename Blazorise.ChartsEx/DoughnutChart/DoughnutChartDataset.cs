using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class DoughnutChartDataset<T> : PieChartDataset<T>
  {
    public DoughnutChartDataset()
      : base()
    {
      Type = "doughnut";
    }
  }
}
