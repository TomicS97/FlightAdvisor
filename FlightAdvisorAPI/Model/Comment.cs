using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAdvisorAPI.Model
{
    public class Comment
    {
        public string CommentID { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string User { get; set; }
        public string Created { get; set; }
        public string Modified { get; set; }

        public void InsertComment()
        {
            string sql = SQLHelper.AddComment(Guid.NewGuid().ToString(),"West Sale Airport", "Prvi komentar", "user1",DateTime.Now,DateTime.Now);
            SQLHelper.ExecuteCommand(sql);
        }

        public void InsertComment(string id,string city,string coment,string user)
        {
            string sql = SQLHelper.AddComment(id, city, coment, user, DateTime.Now, DateTime.Now);
            SQLHelper.ExecuteCommand(sql);
        }

        public void Update(string id, string comment, DateTime a)
        {
            string sql = Comment.UpdateComm(id, comment, a);
            SQLHelper.ExecuteCommand(sql);
        }
        
        public void Delete(string id,string user)
        {
            string sql = Comment.DeleteComm(id,user);
            SQLHelper.ExecuteCommand(sql);
        }
        public List<Comment> GetAllComment()
        {

            List<Comment> temp = SQLHelper.GetAllComList();
            return temp;
        }
        public List<Comment> GetAllCommentSelected(string c)
        {

            List<Comment> temp = SQLHelper.GetAllComListSelected(c);
            return temp;
        }

        public static string GetComm()
        {
            string ret = "select * from CommentTable";

            return ret;
        }
        public static string GetCommSelected(string s)
        {
            string ret = "select * from CommentTable where cityname='" + s +"'";

            return ret;
        }
        public static string DeleteComm(string commentID,string user)
        {
            string ret = "delete from CommentTable where commentID='" + commentID + "' and user='"+ user +"'";

            return ret;
        }
        public static string UpdateComm(string commentID,string tekst,DateTime a)
        {
            string ret = "update CommentTable set comment='" + tekst+"', modified='"+a+"' where commentID='"+commentID+"'";

            return ret;
        }


    }
}
