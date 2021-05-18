using System;
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

    #region Specifics

    [DataContract]
    public class LineChartOptions : ChartOptions
    {
        /// <summary>
        /// If false, the lines between points are not drawn.
        /// </summary>
        [DataMember]
        public bool ShowLines { get; set; } = true;

        /// <summary>
        /// If false, NaN data causes a break in the line.
        /// </summary>
        [DataMember]
        public bool SpanGaps { get; set; }
    }

    [DataContract]
    public class BarChartOptions : ChartOptions
    {
        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category width. 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        [DataMember]
        public float BarPercentage { get; set; } = 0.9f;

        /// <summary>
        /// Percent (0-1) of the available width each category should be within the sample width. 
        /// </summary>
        [DataMember]
        public float CategoryPercentage { get; set; } = 0.8f;

        /// <summary>
        /// Manually set width of each bar in pixels. If not set, the base sample widths are calculated automatically so that they take the full available widths without overlap. Then, the bars are sized using barPercentage and categoryPercentage.
        /// </summary>
        [DataMember]
        public int BarThickness { get; set; }

        /// <summary>
        /// Set this to ensure that bars are not sized thicker than this.
        /// </summary>
        [DataMember]
        public int MaxBarThickness { get; set; }
    }

    [DataContract]
    public class PieChartOptions : ChartOptions
    {
        /// <summary>
        /// The percentage of the chart that is cut out of the middle.
        /// </summary>
        [DataMember]
        public int CutoutPercentage { get; set; } = 0;

        /// <summary>
        /// Starting angle to draw arcs from.
        /// </summary>
        [DataMember]
        public double Rotation { get; set; } = -0.5 * Math.PI;

        /// <summary>
        /// Sweep to allow arcs to cover.
        /// </summary>
        [DataMember]
        public double Circumference { get; set; } = 2 * Math.PI;
    }

    [DataContract]
    public class DoughnutChartOptions : PieChartOptions
    {
        /// <summary>
        /// The percentage of the chart that is cut out of the middle.
        /// </summary>
        [DataMember]
        public new int CutoutPercentage { get; set; } = 50;
    }

    [DataContract]
    public class PolarAreaChartOptions : ChartOptions
    {
        /// <summary>
        /// Starting angle to draw arcs for the first item in a dataset.
        /// </summary>
        [DataMember]
        public double StartAngle { get; set; } = -0.5 * Math.PI;
    }

    [DataContract]
    public class RadarChartOptions : ChartOptions
    {
        // Unlike other charts, the radar chart has no chart specific options.
    }

    #endregion
}
