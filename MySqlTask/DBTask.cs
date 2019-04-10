using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using fhl165033213.MySqlTask;
using fhl165033213.Enity;


namespace fhl165033213.MySqlTask
{
   public  class DBTask
    {
       private string fhl165033213Constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lenovo\Desktop\fhl165033213\WebUI\App_Data\fhl165033213.mdf;Integrated Security=True";
       private SqlConnection myBCon;
       private void createConnection()
       {
           try
           {
               myBCon = new SqlConnection(fhl165033213Constr);
               myBCon.Open();
           }
           catch
           {
               return;
           }
       }
       public User getRegUser(User user)
       {
           User user1 = null;
           string mySql = "select * from userfhl where username=N'"+ user.Username + "'";
           createConnection();
           SqlCommand cmd = new SqlCommand(mySql, myBCon);
           SqlDataReader dr = cmd.ExecuteReader();
           if(dr.Read())
           {
               user1 = new User();
               user1.Username = Convert.ToString(dr["username"]);
               user1.Password = Convert.ToString(dr["password"]);
           }
           return  user1;


       }
    }
}
