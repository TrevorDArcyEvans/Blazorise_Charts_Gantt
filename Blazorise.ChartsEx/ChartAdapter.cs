using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blazorise.ChartsEx
{
    public class ChartAdapter
    {
        private readonly IBaseChart chart;

        public ChartAdapter( IBaseChart chart )
        {
            this.chart = chart;
        }

        [JSInvokable]
        public Task Event( string eventName, int datasetIndex, int index, string model )
        {
            return chart.Event( eventName, datasetIndex, index, model );
        }
    }
}
