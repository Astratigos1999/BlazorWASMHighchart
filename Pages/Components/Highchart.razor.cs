namespace FrontEndWASM.Pages.Components
{
    public partial class Highchart
    {
        [Parameter]
        public List<SampleData> SampleData { get; set; } //  δεν επεξεργαζόμαστε τα δεδομένα 
        public List<SampleData> TableData { get; set; } // δεδομένα πίνακα που χρησιμοποιούνται ως αναφορά για τον πίνακα

        public List<SampleData>? IndexA { get; set; }
        public List<SampleData>? IndexB { get; set; }
        public List<SampleData>? IndexC { get; set; }

        public List<object>? SeriesValuesA { get; set; } = new List<object>();
        public List<object>? SeriesValuesB { get; set; } = new List<object>();
        public List<object>? SeriesValuesC { get; set; } = new List<object>();


        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
            if (firstRender)
            {
                chartService.RenderChart("basicLine", BasicLineGraph.Generate());
            }
        }


        public ChartObject BasicLineGraph = new ChartObject()
        {
            Legend = new Legend(true, Layout.Vertical, Allegiance.Blazor.Highcharts.Constants.Align.Right, VerticalAlign.Middle),
            PlotOptions = new PlotOptions(new PlotOptionsSeries(new Label(false), 2019, 10)),
            Responsive = new Responsive(
            new Rule(
                new Condition(300),
                new Allegiance.Blazor.Highcharts.Options.ChartOptions(
                        new Legend(true, Layout.Vertical, Allegiance.Blazor.Highcharts.Constants.Align.Right, VerticalAlign.Middle)
                    )
                )
            ),
            Series = new List<SeriesElement>()
            {
                 new SeriesElement("Index A", new List<object>()
                 {

                 }),
                 new SeriesElement("Index B", new List<object>()
                 {

                 }),
                 new SeriesElement("Index C", new List<object>()
                 {

                 }),
            },
            Title = new Title("Front-End Test Chart"),
            YAxis = new YAxis(
               new Title("Title of Y-axis")
               ),
            XAxis = new XAxis(
               new Accessibility("Title of X-axis")
               )
        };

        protected override void OnInitialized()
        {
            TableData = SampleData;
            IndexA = SampleData.Where(sd => sd.Index == "A").ToList();
            IndexB = SampleData.Where(sd => sd.Index == "B").ToList();
            IndexC = SampleData.Where(sd => sd.Index == "C").ToList();
            IndexA.ForEach(delegate (SampleData data) { data.Values.ForEach(delegate (Values values) { BasicLineGraph.Series[0].Data.Add(values.Value1.Number); BasicLineGraph.Series[0].Data.Add(values.Value2.Number); BasicLineGraph.Series[0].Data.Add(values.Value3.Number); }); });
            IndexB.ForEach(delegate (SampleData data) { data.Values.ForEach(delegate (Values values) { BasicLineGraph.Series[1].Data.Add(values.Value1.Number); BasicLineGraph.Series[1].Data.Add(values.Value2.Number); BasicLineGraph.Series[1].Data.Add(values.Value3.Number); }); });
            IndexC.ForEach(delegate (SampleData data) { data.Values.ForEach(delegate (Values values) { BasicLineGraph.Series[2].Data.Add(values.Value1.Number); BasicLineGraph.Series[2].Data.Add(values.Value2.Number); BasicLineGraph.Series[2].Data.Add(values.Value3.Number); }); });
        }

        protected async Task DateChange(DateRange dateRange)
        {
            BasicLineGraph.PlotOptions.Series.PointStart = Convert.ToDouble(dateRange.Start.Value.Year);
            TableData = SampleData.Where(s => s.DateTime >= dateRange.Start.Value).Where(s => s.DateTime <= dateRange.End.Value).ToList();
            IndexA.Where(s => s.DateTime >= dateRange.Start.Value).Where(s => s.DateTime <= dateRange.End.Value).ToList().ForEach(delegate (SampleData data)
            {
                data.Values.ForEach(delegate (Values values)
                {
                    SeriesValuesA.Add(values.Value1.Number);
                    SeriesValuesA.Add(values.Value2.Number);
                    SeriesValuesA.Add(values.Value3.Number);
                });
            });
            IndexB.Where(s => s.DateTime >= dateRange.Start.Value).Where(s => s.DateTime <= dateRange.End.Value).ToList().ForEach(delegate (SampleData data)
            {
                data.Values.ForEach(delegate (Values values)
                {
                    SeriesValuesB.Add(values.Value1.Number);
                    SeriesValuesB.Add(values.Value2.Number);
                    SeriesValuesB.Add(values.Value3.Number);
                });
            });
            IndexC.Where(s => s.DateTime >= dateRange.Start.Value).Where(s => s.DateTime <= dateRange.End.Value).ToList().ForEach(delegate (SampleData data)
            {
                data.Values.ForEach(delegate (Values values)
                {
                    SeriesValuesC.Add(values.Value2.Number);
                    SeriesValuesC.Add(values.Value3.Number);
                    SeriesValuesC.Add(values.Value1.Number);
                });
            });
            BasicLineGraph.Series[0].Data = SeriesValuesA;
            BasicLineGraph.Series[1].Data = SeriesValuesB;
            BasicLineGraph.Series[2].Data = SeriesValuesC;
            StateHasChanged();
            await chartService.RenderChart("basicLine", BasicLineGraph.Generate());
        }

        public void Dispose()
        {
            BasicLineGraph.DisposeChart(jsRuntime, "basicLine");
        }
    }
}
