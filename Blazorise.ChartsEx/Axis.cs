using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
  [DataContract]
  public class Axis
  {
    [DataMember( EmitDefaultValue = false )]
    public string Type { get; set; }

    [DataMember]
    public bool Display { get; set; } = true;

    [DataMember( EmitDefaultValue = false )]
    public AxisTicks Ticks { get; set; }

    [DataMember( EmitDefaultValue = false )]
    public AxisGridLines GridLines { get; set; }

    [DataMember( EmitDefaultValue = false )]
    public AxisScaleLabel ScaleLabel { get; set; }

    [DataMember( EmitDefaultValue = false )]
    public bool Stacked { get; set; }
  }
}
