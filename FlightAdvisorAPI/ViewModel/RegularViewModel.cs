using FlightAdvisorAPI.Model;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FlightAdvisorAPI.ViewModel
{
    public class RegularViewModel
    {
        public Window Window { get; set; }
        public ObservableCollection<City> CitiesList { get; set; }
        public ObservableCollection<Comment> CommentList { get; set; }
        public ObservableCollection<Routes> FlightList { get; set; }

        public String User { get; set; }
        public String Search { get; set; }
        public String TekstKom { get; set; }
        public String FlFrom { get; set; }
        public String FlTo { get; set; }
        public City Selected { get; set; }              //selektovan grad
        public Model.Comment SelectedCom { get; set; }
        public MyICommand ShowAllCity { get; set; }
        public MyICommand LogOutt { get; set; }
        public MyICommand AddComment { get; set; }
        public MyICommand EditComment { get; set; }
        public MyICommand DeleteComment { get; set; }
        public MyICommand SearchCity { get; set; }
        public MyICommand WholeComment { get; set; }
        public MyICommand ShowFlight { get; set; }
        



        public RegularViewModel(string username)
        {
            ShowAllCity = new MyICommand(OnShowAll);
            LogOutt = new MyICommand(OnLogout);
            AddComment = new MyICommand(onAddComm);
            SearchCity = new MyICommand(OnSearch);
            EditComment = new MyICommand(OnEditComm);
            DeleteComment = new MyICommand(OnDeleteComm);
            WholeComment = new MyICommand(OnViewComment);
            ShowFlight = new MyICommand(OnShowFlight);

            User = username;
            

            CitiesList = new ObservableCollection<City>();
            CommentList = new ObservableCollection<Comment>();
            FlightList = new ObservableCollection<Routes>();

        }

        private void OnShowFlight()
        {
            List<Airports> listaGradovafrom = new List<Airports>();
            List<Airports> listaGradovato = new List<Airports>();
            List<Routes> ListaRuta = new List<Routes>();

            FlightList.Clear();
            Airports c = new Airports();
            Routes r = new Routes();
            listaGradovafrom = c.GetInnerAllFrom(FlFrom);
            listaGradovato = c.GetInnerAllTo(FlTo);
            ListaRuta = r.ListOfRoutes();

            foreach (var From in listaGradovafrom)
            {
                foreach (var To in listaGradovato)
                {
                    foreach (var rute in ListaRuta)
                    {

                        if (rute.From== From.airIATA && rute.To==To.airIATA)
                        {
                            rute.From = FlFrom;
                            rute.To = FlTo;
                            FlightList.Add(rute);
                            
                        }
                    }

                }
            }
            
        }

        private void OnViewComment()
        {
            if (SelectedCom == null)
            {
                MessageBox.Show("You did not selected any comment to view!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Window = new View.Comment();
                Window.DataContext = new CommentViewModel(User, TekstKom, "view", SelectedCom, "") { Window = Window };
                Window.Show();
            }
        }

        
        private void OnDeleteComm()
        {
            if (SelectedCom == null)
            {
                MessageBox.Show("You did not selected any comment to delete!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Comment cc = new Comment();
                cc.Delete(SelectedCom.CommentID,User);
            }
            OnShowAll();
        }

        private void OnEditComm()
        {
            if (SelectedCom == null)
            {
                MessageBox.Show("You did not selected any comment to edit!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Window = new View.Comment();
                Window.DataContext = new CommentViewModel(SelectedCom.CommentID.ToString(), TekstKom, "edit", SelectedCom,"") { Window = Window };
                Window.Show();
            }
        }

        private void OnSearch()
        {
            List<City> listaGradova = new List<City>();
            City sc = new City();
            CitiesList.Clear();
            listaGradova = sc.GetSearchDone(Search);
            foreach (var item in listaGradova)
            {
                CitiesList.Add(item);
            }
        }

        private void onAddComm()
        {
            if (Selected == null)
            {
                MessageBox.Show("You did not selected any city to add comment!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Window = new View.Comment();
                Window.DataContext = new CommentViewModel(User, "", "add", SelectedCom, Selected.CityName.ToString()) { Window = Window };
                Window.Show();
            }
        }

        public void KomentarAdded(string s, string u,string city)
        {
            //saljemo u bazu
            Comment noviK = new Comment();
            noviK.InsertComment(Guid.NewGuid().ToString(), city, s, u);
        }

        private void OnLogout()
        {
            Window.Hide();
            Window = new MainWindow();
            Window.DataContext = new LoginViewModel() { Window = Window };
            Window.Show();
        }

        public void OnShowAll()
        {
            bool check = true;
        

            if (check)
            {
                if (Selected == null)
                {
                    List<City> listaGradova = new List<City>();

                    CitiesList.Clear();
                    City c = new City();
                    listaGradova = c.GetAllCitiesListDone();
                    foreach (var item in listaGradova)
                    {
                        CitiesList.Add(item);
                        
                    }

                   
                    List<Comment> com = new List<Comment>();

                    Comment ccc = new Comment();
                    CommentList.Clear();

                    com = ccc.GetAllComment();
                    foreach (var item in com)
                    {

                        CommentList.Add(item);

                    }
                }
                else
                {
                    List<City> listaGradova = new List<City>();

                    
                    City c = new City();
                    c.CityName = Selected.CityName;
                    List<Comment> com = new List<Comment>();
                    Comment ccc = new Comment();
                    CommentList.Clear();

                    com = ccc.GetAllCommentSelected(c.CityName.ToString());
                    foreach (var item in com)
                    {
                        CommentList.Add(item);

                    }
                    Selected = null;
                }



            }
        }

    }
}
