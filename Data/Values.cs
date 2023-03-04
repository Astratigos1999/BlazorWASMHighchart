namespace FrontEndWASM.Data
{
    public class Value
    {
        public double? Number { get; set; }
        public bool? ExceedsThreshold { get; set; }
    }

    public class Values
    {
        public Value? Value1 { get; set; }
        public Value? Value2 { get; set; }
        public Value? Value3 { get; set; }
    }

}
