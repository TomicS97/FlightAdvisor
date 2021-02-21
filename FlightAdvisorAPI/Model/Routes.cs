
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAdvisorAPI.Model
{
    public class Routes
    {
        public string From { get; set; }
        public string To { get; set; }

        public string Price { get; set; }
        public Path p = new Path();
        public void SQLRoutes()
        {
            string[] lines = File.ReadAllLines(p.RoutePath());
            string[] partlines;
            List<string> gradovi = SQLHelper.GetAirIata();

            foreach (var l in lines)
            {

                partlines = l.Split(',');

                foreach (var item in gradovi)
                {
                    if (partlines[2].ToString() == item)
                    {
                        InsertRoutes(partlines[0], partlines[1], partlines[2], partlines[3], partlines[4], partlines[5], partlines[6], partlines[7], partlines[8], partlines[9]);
                    }
                }


            }
        }
        public void InsertRoutes(string airportID, string airname, string aircity, string aircountry, string airIATA, string airICAO, string airlatitude, string airlongitude, string airaltitude, string airtimezone)       //potrebna izmena naziva
        {
            string sql = SQLHelper.InsertRout(airportID, Guid.NewGuid().ToString(), aircity, aircountry, airIATA, airICAO, airlatitude, airlongitude, airaltitude, airtimezone);
            SQLHelper.ExecuteCommand(sql);
        }


        public List<Routes> ListOfRoutes()
        {
            List<Routes> list = SQLHelper.GetAllRoutes();
            return list;
        }

        public void UpdateNewRoute(string cityName)
        {
            string[] lines = File.ReadAllLines(p.RoutePath());
            string[] partlines;
            List<string> gradovi = SQLHelper.GetSpecAirIata(cityName);

            foreach (var l in lines)
            {

                partlines = l.Split(',');

                foreach (var item in gradovi)
                {
                    if (partlines[2].ToString() == item)
                    {
                        InsertRoutes(partlines[0], partlines[1], partlines[2], partlines[3], partlines[4], partlines[5], partlines[6], partlines[7], partlines[8], partlines[9]);
                    }
                }
            }
        }

    }
}
