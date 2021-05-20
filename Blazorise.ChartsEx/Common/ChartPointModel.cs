using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class ChartPointModel : ChartModel
  {
    [JsonPropertyName("x")]
    public double X { get; set; }
  }

  /* ======== IMPORTANT ========
  * The reason why base ChartPointModel class is not used is because the Blazor serializer does not support inheritance.
  * Until that is fixed we must write every model without inherit fields.
  * =========================== */
}
