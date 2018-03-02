using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager.Model
{
    public class RoomModel
    {
        public int id { get; set; }
        public String Name { get; set; }
        public int Elec { get; set; }
        public int Water { get; set; }

        public RoomModel()
        {
        }

        public RoomModel(int valueRoom, string v, int text1, int text2)
        {
            this.id = valueRoom;
            this.Name = v;
            this.Elec = text1;
            this.Water = text2;
        }

      
    }
}
