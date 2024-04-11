using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trak.Domain
{
    public class Users
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Sird_Name { get; set; }
        public string Password { get; set; }
        public string Place_of_work { get; set; }
        public string Position { get; set; }

        public Users(int id_, string Name_, string Sird_Name_, string Password_, string Place_of_work_, string Position_)
        {
            this.id = id_;
            this.Name = Name_;
            this.Sird_Name = Sird_Name_;
            this.Password = Password_;
            this.Place_of_work = Place_of_work_;
            this.Position = Position_;
        }
    }
}
