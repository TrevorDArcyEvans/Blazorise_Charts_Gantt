using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  /// <summary>
  /// Defines options for the scale title.
  /// </summary>
  public class AxisScaleLabel
  {
    /// <summary>
    /// If true, display the axis title.
    /// </summary>
    [DataMember]
    public bool Display { get; set; }

    /// <summary>
    /// The text for the title. (i.e. "# of People" or "Response Choices").
    /// </summary>
    [DataMember]
    public string LabelString { get; set; } = "";

    /// <summary>
    /// Height of an individual line of text (<see cref="https://developer.mozilla.org/en-US/docs/Web/CSS/line-height"/>).
    /// </summary>
    [DataMember]
    public double LineHeight { get; set; } = 1.2d;

    /// <summary>
    /// Font color for scale title.
    /// </summary>
    [DataMember]
    public string FontColor { get; set; } = "#666";

    /// <summary>
    /// Font family for the scale title, follows CSS font-family options.
    /// </summary>
    [DataMember]
    public string FontFamily { get; set; } = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";

    /// <summary>
    /// Font size for scale title.
    /// </summary>
    [DataMember]
    public double FontSize { get; set; } = 12;

    /// <summary>
    /// Font style for the scale title, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
    /// </summary>
    [DataMember]
    public string FontStyle { get; set; } = "normal";

    /// <summary>
    /// Padding to apply around scale labels. Only top and bottom are implemented.
    /// </summary>
    [DataMember]
    public object Padding { get; set; } = 4;
  }
}
