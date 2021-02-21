using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using FlightAdvisorAPI.View;

namespace FlightAdvisorAPI.Model
{
    public static class SQLHelper
    {

        static SQLiteConnection m_dbConnection;
        static string myDatabaseFileName = "MyDatabase.sqlite";
        static string UserTable = "Users";
        static string AirportsTable = "AirportsTable";
        static string CityTable = "CitiesTable";
        static string CommentTable = "CommentTable";
        static string RoutesTable = "RoutesTable";



        static SQLHelper()
        {

            if (!File.Exists(@"D:/FlightAdvisor-Srdjan/FlightAdvisorAPI/bin/Debug/MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile(myDatabaseFileName);

                m_dbConnection = new SQLiteConnection("Data Source=" + myDatabaseFileName + ";Version=3;");
                m_dbConnection.Open();


                //Users
                string sqluser = "create table " + UserTable +
                    " (firstname varchar(30)," +
                    "lastname varchar(30)," +
                    "username varchar(30)," +
                    "password varchar(30)," +
                    "salt varchar(20)," +
                    "hashedpass varchar(100)," +
                    "role varchar(8)," +
                    "PRIMARY KEY(username))";


                //Airports
                string sqlairports = "create table " + AirportsTable +
                    " (airportID varchar(10)," +
                    "airname varchar(30)," +
                    "aircity varchar(30)," +
                    "aircountry varchar(30)," +
                    "airIATA varchar(30)," +
                    "airICAO varchar(30)," +
                    "airlatitude varchar(30)," +
                    "airlongitude varchar(30)," +
                    "airaltitude varchar(8)," +
                    "airtimezone varchar(5)," +
                    "airdst varchar(2)," +
                    "airdbtimezone varchar(30)," +
                    "airtype varchar(30)," +
                    "airsource varchar(30)," +
                    "PRIMARY KEY(airportID))";


                //City
                string sqlcity = "create table " + CityTable +
                        " (Citi varchar(30)," +
                        "Country varchar(30)," +
                        "Description varchar(200)," +
                        "PRIMARY KEY(Citi))";


                //Comments
                string sqlcomment = "create table " + CommentTable +
                        " (commentID varchar(30)," +
                        "cityname varchar(30)," +
                        "comment varchar(200)," +
                        "user varchar(30)," +
                        "created varchar(30)," +
                        "modified varchar(30)," +
                        "PRIMARY KEY (commentID)," +
                        "FOREIGN KEY(cityname) REFERENCES CitiesTable(Citi)," +
                        "FOREIGN KEY(user) REFERENCES Tabela(username))";


                //Routes
                string sqlroutes = "create table " + RoutesTable +
                        " (airline varchar(10)," +
                        "airlineID varchar(30)," +
                        "sourceair varchar(30)," +
                        "sourceID varchar(30)," +
                        "destair varchar(30)," +
                        "destairID varchar(30)," +
                        "codeshare varchar(30)," +
                        "stops varchar(30)," +
                        "equipment varchar(8)," +
                        "price varchar(5)," +
                        "CONSTRAINT PK_Routes PRIMARY KEY (airlineID,sourceID,destairID)" +
                        "FOREIGN KEY(sourceID) REFERENCES AirportsTable(airIATA)," +
                        "FOREIGN KEY(destairID) REFERENCES AirportsTable(airIATA))";

                ExecuteCommand(sqluser);
                ExecuteCommand(sqlairports);
                ExecuteCommand(sqlcity);
                ExecuteCommand(sqlcomment);
                ExecuteCommand(sqlroutes);
                //Pocetna inicijalizacija baze. Zakomentarisati sledece dve linije u slucaju kretanja od nule!
                //InitialDatabase i = new InitialDatabase();
                //i.InitDatabase();
            }
            else
            {
                m_dbConnection = new SQLiteConnection("Data Source=" + myDatabaseFileName + ";Version=3;");
                m_dbConnection.Open();
            }

            //m_dbConnection.Close();
        }


        public static void ExecuteCommand(string commands)
        {
            SQLiteCommand command = new SQLiteCommand(commands, m_dbConnection);
            command.ExecuteNonQuery();
        }

        #region City
        public static string AddCity(string city, string country, string description)       //Adding new city - admin view
        {

            string ret = "insert into " + CityTable + " (Citi,Country,Description) values ('" +
                city + "','" + country + "','" + description + "')";

            return ret;
        }

        public static List<string> GetCitiesName()                                          //get all cities names from database    
        {
            string temp;
            List<string> sviGradovi = new List<string>();
            temp = City.GetCityName();
            SQLiteCommand command = new SQLiteCommand(temp, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sviGradovi.Add(reader["Citi"].ToString());
            }
            return sviGradovi;
        }
        //Searching regular view
        public static List<City> SearchCityDatabase(string s)
        {
            string temp;
            List<City> sviGradovi = new List<City>();
            temp = City.GetSearchedCity(s);
            SQLiteCommand command = new SQLiteCommand(temp, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                City tt = new City();
                tt.CityName = reader["Citi"].ToString();
                tt.Country = reader["Country"].ToString();
                tt.Description = reader["Description"].ToString();

                sviGradovi.Add(tt);
            }
            return sviGradovi;
        }

        public static List<City> GetAllCitiesTableList()
        {
            string temp;
            List<City> sviGradovi = new List<City>();

            temp = City.GetAllCitiesTable();
            SQLiteCommand command = new SQLiteCommand(temp, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                City tt = new City();
                tt.CityName = reader["Citi"].ToString();
                tt.Country = reader["Country"].ToString();
                tt.Description = reader["Description"].ToString();

                sviGradovi.Add(tt);
            }
            return sviGradovi;
        }
        #endregion

        #region Users

        //autentifikacija
        public static List<Tuple<string, string>> ExecuteCommandReadLogin(string commands)
        {
            string aa;
            string bb;
            List<Tuple<string, string>> autentifikacija = new List<Tuple<string, string>>();


            SQLiteCommand command = new SQLiteCommand(commands, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader["role"].ToString() == "admin")
                    aa = "1" + reader["username"].ToString();
                else
                    aa = "2" + reader["username"].ToString();

                bb = reader["password"].ToString();
                autentifikacija.Add(Tuple.Create(aa, bb));

            }

            return autentifikacija;
        }

        public static string GetUsersLogin()
        {

            string ret = "select * from " + UserTable;

            return ret;
        }
        //Add new user - registration
        public static string GetSqlCommand(string firstname, string lastname, string username, string password, string salt, string hashedpass, string role)
        {

            string ret = "insert into " + UserTable + " (firstname,lastname,username,password,salt,hashedpass,role) values ('" +
                firstname + "','" +
                lastname + "','" +
                username + "', '" +
                password + "', '" +
                salt + "', '" +
                hashedpass + "', '" +
                role + "')";

            return ret;
        }

        #endregion Users

        #region Airports
        public static string InsertAirs(string airportID, string airname, string aircity, string aircountry, string airIATA, string airICAO, string airlatitude, string airlongitude, string airaltitude, string airtimezone, string airdst, string airdbtimezone, string airtype, string airsource)       //potrebna dorada
        {

            string ret = "insert into " + AirportsTable + " (airportID,airname,aircity,aircountry,airIATA,airICAO,airlatitude,airlongitude,airaltitude,airtimezone,airdst,airdbtimezone,airtype,airsource) values ('" +
                airportID + "','" + airname + "','" + aircity + "', '" + aircountry + "', '" + airIATA + "','" + airICAO + "','" + airlatitude + "', '" + airlongitude + "', '" + airaltitude + "','" + airtimezone + "','" + airdst + "', '" + airdbtimezone + "', '" + airtype + "', '" + airsource + "')";

            return ret;
        }

        public static List<string> GetAirIata()
        {
            string temp;
            List<string> sviAir = new List<string>();
            temp = Airports.GetAirIata();
            SQLiteCommand command = new SQLiteCommand(temp, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sviAir.Add(reader["airIATA"].ToString());
            }
            return sviAir;
        }
        public static List<string> GetSpecAirIata(string cityname)
        {
            string temp;
            List<string> sviAir = new List<string>();
            temp = Airports.InnerAirRout(cityname);
            SQLiteCommand command = new SQLiteCommand(temp, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sviAir.Add(reader["airIATA"].ToString());
            }
            return sviAir;
        }
        #endregion

        #region Routes
        public static string InsertRout(string airline, string airlineID, string sourceair, string sourceID, string destair, string destairID, string codeshare, string stops, string equipment, string price)
        {

            string ret = "insert into " + RoutesTable + " (airline,airlineID,sourceair,sourceID,destair,destairID,codeshare,stops,equipment,price) values ('" +
                airline + "','" + airlineID + "','" + sourceair + "', '" + sourceID + "', '" + destair + "','" + destairID + "','" + codeshare + "', '" + stops + "', '" + equipment + "','" + price + "')";

            return ret;
        }
        //Nazalost u SQLite ne postoji full join. Sledece tri metode su zamena.
        public static List<Airports> GetInnerListFrom(string from)
        {
            string tempFrom;
            List<Airports> sviAirFrom = new List<Airports>();

            tempFrom = Airports.InnerAirRout(from);

            SQLiteCommand command = new SQLiteCommand(tempFrom, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Airports tt = new Airports();
                tt.airIATA = reader["airIATA"].ToString();

                sviAirFrom.Add(tt);
            }

            return sviAirFrom;
        }
        public static List<Airports> GetInnerListTo(string to)
        {
            string tempTo;
            List<Airports> sviAirTo = new List<Airports>();

            tempTo = Airports.InnerAirRout(to);

            SQLiteCommand command = new SQLiteCommand(tempTo, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Airports tt = new Airports();
                tt.airIATA = reader["airIATA"].ToString();

                sviAirTo.Add(tt);
            }

            return sviAirTo;
        }

        public static List<Routes> GetAllRoutes()
        {
            string tempFrom;
            List<Routes> sviAirFrom = new List<Routes>();

            tempFrom = "select * from RoutesTable";

            SQLiteCommand command = new SQLiteCommand(tempFrom, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Routes tt = new Routes();
                tt.From = reader["sourceair"].ToString();
                tt.To = reader["destair"].ToString();
                tt.Price = reader["price"].ToString();

                sviAirFrom.Add(tt);
            }

            return sviAirFrom;
        }



        #endregion

        #region Comment

        public static List<Comment> GetAllComList()
        {
            string temp;
            List<Comment> sviGradovi = new List<Comment>();

            temp = Comment.GetComm();
            SQLiteCommand command = new SQLiteCommand(temp, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Comment tt = new Comment();
                tt.CommentID = reader["commentID"].ToString();
                tt.City = reader["cityname"].ToString();
                tt.Comments = reader["comment"].ToString();
                tt.User = reader["user"].ToString();
                tt.Created = reader["created"].ToString();
                tt.Modified = reader["modified"].ToString();

                sviGradovi.Add(tt);
            }
            return sviGradovi;
        }
        public static List<Comment> GetAllComListSelected(string s)
        {
            string temp;
            List<Comment> sviGradovi = new List<Comment>();

            temp = Comment.GetCommSelected(s);
            SQLiteCommand command = new SQLiteCommand(temp, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Comment tt = new Comment();
                tt.CommentID = reader["commentID"].ToString();
                tt.City = reader["cityname"].ToString();
                tt.Comments = reader["comment"].ToString();
                tt.User = reader["user"].ToString();
                tt.Created = reader["created"].ToString();
                tt.Modified = reader["modified"].ToString();

                sviGradovi.Add(tt);
            }
            return sviGradovi;
        }

        public static string AddComment(string commentID, string cityname, string comment, string user, DateTime datec, DateTime datem)
        {

            string ret = "insert into " + CommentTable + " (commentID,cityname,comment,user,created,modified) values ('" +
                commentID + "','" + cityname + "','" + comment + "','" + user + "','" + datec + "','" + datem + "')";

            return ret;
        }


        #endregion




    }
}
