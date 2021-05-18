using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class GanttChartInterval<T>
  {
    [JsonPropertyName("from")]
    public T From { get; set; }

    [JsonPropertyName("to")]
    public T To { get; set; }
  }
}
