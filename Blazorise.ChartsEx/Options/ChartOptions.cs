using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
    [DataContract]
    public class ChartOptions
    {
        [DataMember( EmitDefaultValue = false )]
        public Scales Scales { get; set; }

        [DataMember( EmitDefaultValue = false )]
        public Legend Legend { get; set; }

        [DataMember( EmitDefaultValue = false )]
        public Tooltips Tooltips { get; set; }

        [DataMember( EmitDefaultValue = false )]
        public Animation Animation { get; set; }

        /// <summary>
        /// Resizes the chart canvas when its container does.
        /// </summary>
        [DataMember( EmitDefaultValue = false )]
        public bool? Responsive { get; set; } = true;

        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing.
        /// </summary>
        [DataMember( EmitDefaultValue = false )]
        public bool? MaintainAspectRatio { get; set; } = true;

        /// <summary>
        /// Duration in milliseconds it takes to animate to new size after a resize event.
        /// </summary>
        [DataMember( EmitDefaultValue = false )]
        public double? ResponsiveAnimationDuration { get; set; } = 0;

        /// <summary>
        /// Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas).
        /// Note that this option is ignored if the height is explicitly defined either as attribute or via the style.
        /// </summary>
        [DataMember( EmitDefaultValue = false )]
        public double? AspectRatio { get; set; } = 2;
    }
}
