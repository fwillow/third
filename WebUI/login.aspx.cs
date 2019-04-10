using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using fhl165033213.Enity;
using fhl165033213.WebUI;
using fhl165033213.InterService;

namespace fhl165033213.WebUI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Session["username"] = Request.Form["UserName"];
            Session["password"] = Request.Form["PassWord"];
            User user = new User();
            user.Username = Session["username"].ToString();
            user.Password = Session["password"].ToString();
            string msg=(new LInterService()).loginBookstore(user);
            if (msg=="信息正确")Response .Redirect ("login_success.aspx");
            else 
            {
                Session ["errormsg"]=msg;
                Response .Redirect ("login_failure.aspx");
            }
            
        }
    }
}