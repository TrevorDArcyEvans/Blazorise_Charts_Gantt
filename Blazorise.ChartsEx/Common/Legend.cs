using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class Legend
  {
    /// <summary>
    /// Is the legend shown.
    /// </summary>
    [DataMember]
    public bool Display { get; set; } = true;

    /// <summary>
    /// Marks that this box should take the full width of the canvas (pushing down other boxes). This is unlikely to need to be changed in day-to-day use.
    /// </summary>
    [DataMember]
    public bool FullWidth { get; set; } = true;

    /// <summary>
    /// Legend will show datasets in reverse order.
    /// </summary>
    [DataMember]
    public bool Reverse { get; set; } = false;
  }
}
