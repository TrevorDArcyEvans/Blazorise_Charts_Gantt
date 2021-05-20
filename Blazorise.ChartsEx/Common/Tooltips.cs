using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class Tooltips
  {
    /// <summary>
    /// Are on-canvas tooltips enabled.
    /// </summary>
    [DataMember]
    public bool Enabled { get; set; } = true;
  }
}
