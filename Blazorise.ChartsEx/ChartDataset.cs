using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Blazorise.ChartsEx
{
  /// <summary>
  /// Base class for the chart dataset.
  /// </summary>
  [DataContract]
  public class ChartDataset<T>
  {
    public ChartDataset() { }

    protected ChartDataset(
      string label,
      List<string> backgroundColor,
      List<string> borderColor,
      int borderWidth
    )
    {
      Label = label;
      BackgroundColor = backgroundColor;
      BorderColor = borderColor;
      BorderWidth = borderWidth;
    }

    /// <summary>
    /// Defines the dataset display name.
    /// </summary>
    [DataMember]
    public string Label { get; set; }

    /// <summary>
    /// List of data items.
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    public List<T> Data { get; set; }

    /// <summary>
    ///List of background colors for each of the data items.
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
    [JsonConverter( typeof( IndexableOptionsConverter<object> ) )]
    public IndexableOption<object> BackgroundColor { get; set; }

    /// <summary>
    /// List of border colors for each of the data items.
    /// </summary>
    [DataMember( EmitDefaultValue = false )]
    [JsonIgnore( Condition = JsonIgnoreCondition.WhenWritingNull )]
    [JsonConverter( typeof( IndexableOptionsConverter<object> ) )]
    public IndexableOption<object> BorderColor { get; set; }

    /// <summary>
    /// Defines the border width.
    /// </summary>
    [DataMember]
    public int BorderWidth { get; set; } = 1;

    /// <summary>
    /// Defines the type of a chart dataset.
    /// </summary>
    [DataMember]
    public string Type { get; set; }

    /// <summary>
    /// Drawing order of the dataset. Used mainly for mixed charts. 
    /// </summary>
    [DataMember]
    public int Order { get; set; }
  }
}
