using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAdvisorAPI.Model
{
    public class Path
    {
        public string pathh { get; set; }

        //Potrebno izmeniti i putanju u okviru SQLHelper klase
        public string AirPath()
        {
            pathh = "D:/FlightAdvisor-Srdjan/FlightAdvisorAPI/Model/airports.txt";
            return pathh;
        }
        public string RoutePath()
        {
            pathh = "D:/FlightAdvisor-Srdjan/FlightAdvisorAPI/Model/routes.txt";
            return pathh;
        }
    }
}
