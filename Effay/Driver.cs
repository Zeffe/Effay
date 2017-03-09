using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effay
{
    public class Driver
    {
        public int Store { get; set; }
        public string Name { get; set; }
        public float RackIn { get; set; }
        public float RackStore { get; set; }
        public float AvgRack { get; set; }
        public float AvgLeg { get; set; }
        public float AvgWait { get; set; }
        public float NegWait { get; set; }
        public float Otd15 { get; set; }
        public float Otd20 { get; set; }
        public float AvgOtd { get; set; }
        public float AvgRun { get; set; }
        public float Cdt30 { get; set; }
        public float AvgCdt { get; set; }
        public float OneAndTwo { get; set; }
        public int RunCount { get; set; }
        public float Efficiency { get; set; }

        public void SetAttrib(int attrib, string value)
        {
            try
            {
                switch (attrib)
                {
                    case 1: Store = Convert.ToInt32(value); break;
                    case 2: Name = value; break;
                    case 3: RackIn = Convert.ToSingle(value); break;
                    case 4: RackStore = Convert.ToSingle(value); break;
                    case 5: AvgRack = Convert.ToSingle(value); break;
                    case 6: AvgLeg = Convert.ToSingle(value); break;
                    case 7: AvgWait = Convert.ToSingle(value); break;
                    case 8: NegWait = Convert.ToSingle(value); break;
                    case 9: Otd15 = Convert.ToSingle(value); break;
                    case 10: Otd20 = Convert.ToSingle(value); break;
                    case 11: AvgOtd = Convert.ToSingle(value); break;
                    case 12: AvgRun = Convert.ToSingle(value); break;
                    case 13: Cdt30 = Convert.ToSingle(value); break;
                    case 14: AvgCdt = Convert.ToSingle(value); break;
                    case 15: OneAndTwo = Convert.ToSingle(value); break;
                    case 16: RunCount = Convert.ToInt32(value); break;
                }
            }
            catch { }
        }

        public bool Empty()
        {
            return (RackIn == 0 && RackStore == 0 && AvgRack == 0);
        }

        public object GetAttrib(int attrib)
        {
            switch (attrib)
            {
                case 1: return Store;
                case 2: return Name;
                case 3: return RackIn;
                case 4: return RackStore;
                case 5: return AvgRack;
                case 6: return AvgLeg;
                case 7: return AvgWait;
                case 8: return NegWait;
                case 9: return Otd15;
                case 10: return Otd20;
                case 11: return AvgOtd;
                case 12: return AvgRun;
                case 13: return Cdt30;
                case 14: return AvgCdt;
                case 15: return OneAndTwo;
                case 16: return RunCount;
                default: return -1;
            }
        }

    }
}
