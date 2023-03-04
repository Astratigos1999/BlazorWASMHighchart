using FrontEndWASM.Data;

namespace FrontEndWASM.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public SampleDataService SampleDataService { get; set; }

        public List<SampleData> sample = new List<SampleData>();



        private List<SampleData> ReadData()
        {
            sample = SampleDataService.GetData();
            return sample;
        }

        protected override void OnInitialized()
        {
            ReadData();
        }
    }
}
