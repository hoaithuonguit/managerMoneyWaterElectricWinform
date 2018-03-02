using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager.Model
{
   public class CSVModel
    {
        public int Id { get; set; }
        public String RoomName { get; set; }
        public int OldElect { get; set; }
        public int NewElect { get; set; }
        public int OldWater { get; set; }
        public int NewWater { get; set; }
       
        public int TotalElect { get; set; }
        public int TotalWater { get; set; }
        public int MoneyElect { get; set; }
        public int MoneyWater { get; set; }
        public int Total { get; set; }
        public CSVModel(int id, String Roomname,
            int olde,
            int newe,
            int oldw,
            int neww,
            int totale,
            int totalw,
            int moneye,
            int moneyw,
            int total)
        {
            this.Id = id;
            this.OldElect = olde;
            this.OldWater = oldw;
            this.RoomName = Roomname;
            this.NewElect = newe;
            this.NewWater = neww;
            this.TotalElect = totale;
            this.TotalWater = totalw;
            this.Total = total;
            this.MoneyElect = moneye;
            this.MoneyWater = moneyw;
        }
    }
}
