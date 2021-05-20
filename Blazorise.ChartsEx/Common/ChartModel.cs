using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class ChartModel
  {
    [JsonPropertyName("y")]
    public double Y { get; set; }
  }
}
