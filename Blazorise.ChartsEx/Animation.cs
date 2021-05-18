using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  /// <summary>
  /// Defines the chart animation options.
  /// </summary>
  [DataContract]
  public class Animation
  {
    /// <summary>
    /// The number of milliseconds an animation takes.
    /// </summary>
    [DataMember]
    public int Duration { get; set; } = 1000;

    /// <summary>
    /// Easing function to use. <seealso cref="https://www.chartjs.org/docs/latest/configuration/animations.html#easing"/>
    /// </summary>
    [DataMember]
    public string Easing { get; set; } = "easeOutQuart";
  }
}
