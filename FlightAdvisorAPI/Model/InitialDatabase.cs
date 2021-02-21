using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAdvisorAPI.Model
{
    public class InitialDatabase
    {
       
        public void InitDatabase()
        {
            Users s = new Users();
            s.InsertUsers();

            City c = new City();
            c.InserCity();

            Airports a = new Airports();
            a.SqlAir();

            Comment cc = new Comment();
            cc.InsertComment();

            Routes r = new Routes();
            r.SQLRoutes();

        }
    }
}
