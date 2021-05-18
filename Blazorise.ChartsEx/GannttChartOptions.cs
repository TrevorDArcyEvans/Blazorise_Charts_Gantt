using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
    [DataContract]
    public class GannttChartOptions : ChartOptions
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
}