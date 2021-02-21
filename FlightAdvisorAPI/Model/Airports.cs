using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAdvisorAPI.Model
{
    public class Airports
    {
        public String airIATA { get; set; }
        public List<String> listaNewCities { get; set; }

        public void SqlAir()
        {
            Path p = new Path();
            string[] lines = File.ReadAllLines(p.AirPath());
            string[] partlines;
            List<string> gradovi = SQLHelper.GetCitiesName();

            foreach (var l in lines)
            {
                partlines = l.Split(',');
                for (int i = 0; i < 14; i++)
                {
                    partlines[i] = partlines[i].Trim('\'', '\"');
                    partlines[i].Replace("\\N", "NULL");

                    string item = partlines[i].ToString();
                    StringBuilder msg = new StringBuilder(partlines[i].Length);
                    for (int j = 0; j < item.Length; j++)
                    {
                        if (item[j] != '\'')
                            msg.Append(item[j]);
                    }
                    partlines[i] = msg.ToString();

                }
                foreach (var item in gradovi)
                {
                    if (partlines[2].ToString() == item)
                    {
                        InsertAirs(Guid.NewGuid().ToString(), partlines[1], partlines[2], partlines[3], partlines[4], partlines[5], partlines[6], partlines[7], partlines[8], partlines[9], partlines[10], partlines[11], partlines[12], partlines[13]);

                    }
                }

            }
        }


        public void InsertAirs(string airportID, string airname, string aircity, string aircountry, string airIATA, string airICAO, string airlatitude, string airlongitude, string airaltitude, string airtimezone, string airdst, string airdbtimezone, string airtype, string airsource)       //potrebna dorada
        {
            string sql = SQLHelper.InsertAirs(airportID, airname, aircity, aircountry, airIATA, airICAO, airlatitude, airlongitude, airaltitude, airtimezone, airdst, airdbtimezone, airtype, airsource);
            SQLHelper.ExecuteCommand(sql);

        }

        public static string GetAirIata()
        {
            string ret = "select airIATA from AirportsTable";

            return ret;
        }

        public static string InnerAirRout(string s)
        {
            string ret =
                "select airIATA " +
                "from AirportsTable " +
                "where AirportsTable.aircity='" + s + "'";
            return ret;
        }


        public List<Airports> GetInnerAllFrom(string from)
        {
            List<Airports> temp = SQLHelper.GetInnerListFrom(from);
            return temp;
        }
        public List<Airports> GetInnerAllTo(string to)
        {
            List<Airports> temp = SQLHelper.GetInnerListTo(to);
            return temp;
        }

    }
}
