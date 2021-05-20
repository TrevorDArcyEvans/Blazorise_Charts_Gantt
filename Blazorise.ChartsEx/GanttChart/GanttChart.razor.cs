namespace Blazorise.ChartsEx
{
  public partial class GanttChart<TItem> : BaseChart<GanttChartDataset<TItem>, TItem, GanttChartOptions, GanttChartModel>
  {
    public GanttChart()
    {
      Type = ChartType.Gantt;
    }
  }
}
