using FlightAdvisorAPI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlightAdvisorAPI.ViewModel
{
    public class CommentViewModel
    {
        public Window Window { get; set; }
        public String Tekst { get; set; }
        public String CommentText { get; set; }
        public String SelectedCiti { get; set; }
        public String Userr { get; set; }
        public String Button { get; set; }
        public MyICommand OK { get; set; }

        public bool IsNew { get; set; } = false;
        public int FontSize { get; set; }

        public CommentViewModel(string username,string kom,string choosenButton,Model.Comment Selected,string selectedCity)
        {
            OK = new MyICommand(OnOk);
            Userr = username;
            Button = choosenButton;
            SelectedCiti = selectedCity;
            if (Selected != null)
            {
                if (Button == "edit")
                {
                    CommentText = Selected.Comments;
                }
                else if (Button == "view")
                {
                    CommentText ="Grad: "+Selected.City+"\nKomentar: "+ Selected.Comments +"\n\n\nUser: "+ Selected.User + "\nLast modified: " + Selected.Modified;
                    IsNew = true;
                    FontSize = 18;
                }
            }

        }

        private void OnOk()
        {
            if (Button == "add")
            {
                RegularViewModel r = new RegularViewModel(Userr);
                r.KomentarAdded(CommentText, Userr,SelectedCiti);

            }
            else if(Button == "edit")
            {
                Model.Comment cc = new Model.Comment();
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                cc.Update(Userr, CommentText, dt);
            }

            Window.Hide();
            
        }
    }
}
