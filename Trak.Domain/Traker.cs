using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trak.Domain
{
    public class Tracker
    {
        public int id { get; set; }
        public DateTime Date_of_visit { get; set; }
        public string Purpose_of_the_visit { get; set; }
        public int Creator { get; set; }
        public bool Confirmation { get; set; }
        public int User_Confirmation { get; set; }
        public string Description { get; set; }
        public int Type_Task { get; set; }
        public int Priority { get; set; }

        public Tracker(int id_, DateTime Date_of_visit_, string Purpose_of_the_visit_, int Creator_, bool Confirmation_, int User_Confirmation_, string Description_, int Type_Task_, int Priority_)
        {
            this.id = id_;
            this.Date_of_visit = Date_of_visit_;
            this.Purpose_of_the_visit = Purpose_of_the_visit_;
            this.Creator = Creator_;
            this.Confirmation = Confirmation_;
            this.User_Confirmation = User_Confirmation_;
            this.Description = Description_;
            this.Type_Task = Type_Task_;
            this.Priority = Priority_;
        }
    }
}
