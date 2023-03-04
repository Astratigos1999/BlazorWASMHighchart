namespace FrontEndWASM.Pages.Components
{
    public partial class DatePicker
    {
        [Parameter]
        public EventCallback<DateRange> DateChanged { get; set; }

        public MudDateRangePicker _picker;
        public DateRange _dateRange = new DateRange();
        public DateTime startDate = new DateTime();
        public DateTime endDate = new DateTime();

        public async Task OnDateChangeAsync(DateRange dateRange)
        {
            await DateChanged.InvokeAsync(dateRange);
        }
    }
}
