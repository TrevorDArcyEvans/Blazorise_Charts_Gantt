using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class GanttChartData<T>
  {
    [JsonPropertyName("x")]
    public GanttChartInterval<T> X { get; set; }

    [JsonPropertyName("y")]
    public double Y { get; set; }
  }
}
