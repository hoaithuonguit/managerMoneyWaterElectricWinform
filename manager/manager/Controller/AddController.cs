using manager.database;
using manager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manager.Controller
{
     public class AddController
    {
        public int getElectric (String _Room, int _month)
        {
            int result = 0;
            using (var db = new Entities())
            {
                var elect = (from a in db.Sums
                             where a.Room.Equals(_Room) && a.DateWrite.Month.Equals(_month)
                             select a.Elec
                             ).FirstOrDefault();
                if (elect != 0) result = elect;
                return result;
            }
        }

        public int getWater (String _room, int _month)
        {
            int result = 0;
            using (var db = new Entities())
            {
                var water = (from a in db.Sums
                             where a.Room.Equals(_room) && a.DateWrite.Month.Equals(_month)
                             select a.Water
                             ).FirstOrDefault();
                if (water != 0) result = water;
                return result;
            }
        }
        public void writeDb(List<RoomModel> ls, DateTime date)
        {

            using (var db = new Entities())
            {
                var id = (from a in db.Sums
                          select a).Count();
                for (int i = 0; 
                    i < ls.Count; 
                    i++)
                {
                    Sum sum = new Sum()
                    {
                        ID = id++,
                        DateWrite = date,
                        Room = ls[i].Name,
                        Elec = ls[i].Elec,
                        Water = ls[i].Water,
                        Total = ls[i].Elec * 3000 + ls[i].Water * 5000
                    };
                    db.Sums.Add(sum);
                    db.Entry(sum).State = EntityState.Added;
                    db.SaveChanges();
                }
            }
        }


    }
}
