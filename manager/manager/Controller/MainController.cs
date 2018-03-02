using manager.database;
using manager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace manager.Controller
{
    

    public class MainController
    {
        public List<RoomModel> GetAllValuesByTime(int _month)
        {
            using (var db = new Entities())
            {
                var result = (from a in db.Sums
                              where a.DateWrite.Month.Equals(_month)
                              select new RoomModel()
                              {
                                  id = a.ID,
                                  Name = a.Room,
                                  Elec = a.Elec,
                                  Water = a.Water
                              }).ToList<RoomModel>();
                return result;
            }
        }
        public List<RoomModel> GetAllValues()
        {
            using (var db = new Entities())
            {
                var result = (from a in db.Sums
                              where a.DateWrite.Month.Equals(DateTime.Now.Month -1 )
                              select new RoomModel()
                              {
                                  id = a.ID,
                                  Name = a.Room,
                                  Elec = a.Elec,
                                  Water = a.Water
                              }).ToList<RoomModel>();
                return result;
            }  
        }

      public List<CSVModel> CSVExport()
        {
            using (var db = new Entities())
            {
                var result = (from a in db.Sums
                              where a.DateWrite.Month.Equals(DateTime.Now.Month)
                              select new RoomModel()
                              {
                                  id = a.ID,
                                  Elec = a.Elec,
                                  Name = a.Room,
                                  Water = a.Water
                              }
                              ).ToList<RoomModel>();
                var result_old = (from b in db.Sums
                                  where b.DateWrite.Month.Equals(DateTime.Now.Month -1)
                                  select new RoomModel()
                                  {
                                      id = b.ID,
                                      Elec = b.Elec,
                                      Name = b.Room,
                                      Water = b.Water
                                  }
                              ).ToList<RoomModel>();
                                  
                List<CSVModel> listResult = new List<CSVModel>();
                for (int i = 0; i< result.Count(); i++)
                {
                    listResult.Add( new CSVModel(
                        i,
                        "Phòng " + i.ToString(),
                       result_old[i].Elec,
                       result[i].Elec,
                       result_old[i].Water,
                       result[i].Water,
                       result[i].Elec - result_old[i].Elec,
                       result[i].Water - result_old[i].Water,
                       (result[i].Elec - result_old[i].Elec) * 3000,
                       (result[i].Water - result_old[i].Water) * 5000,
                        (result[i].Elec - result_old[i].Elec) * 3000 + (result[i].Water - result_old[i].Water) * 5000
                       ));
                }
                return listResult;
            }
        }
    }
}
