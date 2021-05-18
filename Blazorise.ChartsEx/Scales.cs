using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class Scales
  {
    [DataMember( EmitDefaultValue = false )]
    public List<Axis> XAxes { get; set; }

    [DataMember( EmitDefaultValue = false )]
    public List<Axis> YAxes { get; set; }
  }
}
