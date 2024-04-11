using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trak.Domain
{
    public class TimeChecker
    {
        public int id { get; set; }
        public TimeSpan Time_Start { get; set; }
        public TimeSpan Time_End { get; set; }
        public string Plase_work { get; set; }
        public int Fre_for_Task { get; set; }

        public TimeChecker(int id_, TimeSpan Time_Start_, TimeSpan Time_End_, string Plase_work_, int Fre_for_Task_)
        {
            this.id = id_;
            this.Time_Start = Time_Start_;
            this.Time_End = Time_End_;
            this.Plase_work = Plase_work_;
            this.Fre_for_Task = Fre_for_Task_;
        }
    }
}
