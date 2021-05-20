using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Blazorise.ChartsEx
{
    /* ======== IMPORTANT ========
     * Blazor serializer does not support DataMember attribute and because of that there is no way to omit null fields when serializing objects to json.
     * Hopefully this will change in the future.
     * =========================== */

    /// <summary>
    /// Base data object for all charts.
    /// </summary>
    /// <typeparam name="TItem">Type of value in the dataset.</typeparam>
    [DataContract]
    public class ChartData<TItem>
    {
        /// <summary>
        /// List of labels for the chart coordinates.
        /// </summary>
        [DataMember( EmitDefaultValue = false )]
        public List<object> Labels { get; set; }

        /// <summary>
        /// List of datasets to be displayed in the chart.
        /// </summary>
        [DataMember( EmitDefaultValue = false )]
        public List<ChartDataset<TItem>> Datasets { get; set; }
    }
}
