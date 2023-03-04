namespace FrontEndWASM.Data
{
    public class SampleDataService
    {
        //Άνάγνωση αρχείου
        public List<SampleData> GetData()
        {
            List<SampleData> sample = new List<SampleData>
            {
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 19),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 19),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 19),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 20),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 20),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=true}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold = true }, Value3= new Value{ Number=0.6, ExceedsThreshold=true } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 20),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 21),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number = null, ExceedsThreshold = null}, Value2 = new Value {Number =null ,  ExceedsThreshold = null }, Value3= new Value{ Number=null, ExceedsThreshold = null } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 21),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= -0.8, ExceedsThreshold=true}, Value2 = new Value {Number = -0.8,  ExceedsThreshold = true }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 21),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 22),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 22),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 22),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 23),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 23),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 23),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 24),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold = true}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold = true }, Value3= new Value{ Number=0.6, ExceedsThreshold = true } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 24),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold = false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold = false }, Value3= new Value{ Number=0.6, ExceedsThreshold = false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 24),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold = true}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold = true }, Value3= new Value{ Number=0.6, ExceedsThreshold = true } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 25),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number = -0.8, ExceedsThreshold = true}, Value2 = new Value {Number = 0.8 ,  ExceedsThreshold = true }, Value3= new Value{ Number=0.6, ExceedsThreshold = false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 25),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 25),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= -0.8, ExceedsThreshold=true}, Value2 = new Value {Number = 0.8 ,  ExceedsThreshold = true }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 26),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 26),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= null, ExceedsThreshold=null}, Value2 = new Value {Number =null ,  ExceedsThreshold = null }, Value3= new Value{ Number = null, ExceedsThreshold = null } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 26),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 27),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 27),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 27),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 28),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 28),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 28),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 29),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 29),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 29),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'A'.ToString(),
                    DateTime = new DateTime(2019, 6, 30),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
                new SampleData
                {
                    Index = 'B'.ToString(),
                    DateTime = new DateTime(2019, 6, 30),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= null, ExceedsThreshold=null}, Value2 = new Value {Number =null ,  ExceedsThreshold = null }, Value3= new Value{ Number = null, ExceedsThreshold = null } }
                    }
                },
                new SampleData
                {
                    Index = 'C'.ToString(),
                    DateTime = new DateTime(2019, 6, 30),
                    Values = new List<Values>
                    {
                        new Values { Value1 = new Value { Number= 0.1, ExceedsThreshold=false}, Value2 = new Value {Number =0.3 ,  ExceedsThreshold= false }, Value3= new Value{ Number=0.6, ExceedsThreshold=false } }
                    }
                },
            };
            sample.OrderBy(o => o.DateTime);

            return sample;
        }
    }
}
