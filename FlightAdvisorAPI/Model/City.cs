using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAdvisorAPI.Model
{
    public class City
    {
        public string CityName { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }

        public void InserCity()
        {
            string sql2 = SQLHelper.AddCity("San Francisco", "SAD", "Very nice city");
            SQLHelper.ExecuteCommand(sql2);

            sql2 = SQLHelper.AddCity("Toronto", "SAD", "City of night life");
            SQLHelper.ExecuteCommand(sql2);
        }

        public void InserCity(string cityname, string countryname, string descript)
        {
            string sql = SQLHelper.AddCity(cityname, countryname, descript);
            SQLHelper.ExecuteCommand(sql);
        }

        public static string GetSearchedCity(string city)
        {
            string ret = "select * from CitiesTable where Citi='" + city + "'";

            return ret;
        }

        public static string GetCityName()
        {
            string ret = "select Citi from CitiesTable";

            return ret;
        }

        public static string GetAllCitiesTable()
        {
            string ret = "select * from CitiesTable";
            return ret;
        }

        public List<City> GetSearchDone(string s)
        {
            List<City> temp = SQLHelper.SearchCityDatabase(s);
            return temp;
        }

        public List<City> GetAllCitiesListDone()
        {
            List<City> temp = SQLHelper.GetAllCitiesTableList();
            return temp;
        }

        public List<string> GetAllCities()
        {
            List<string> temp = SQLHelper.GetCitiesName();
            return temp;
        }
    }
}
