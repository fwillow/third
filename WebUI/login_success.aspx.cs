using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fhl165033213.WebUI
{
    public partial class login_success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            Application.Set("cnt", (int)Application["cnt"] + 1);
            Application.UnLock();
            Response.Write(Session["username"] + "，欢迎登录！您是光临本店的第" + Application["cnt"] + "位顾客<br>");
            Response.Write("网站服务器：" + Request.ServerVariables["SERVER_SOFTWARE"] + "<br>");
            Response.Write("协议：" + Request.ServerVariables["SERVER_PROTOCOL"] + "<br>");
            Response.Write("您使用的浏览器为：" + Request.Browser.Browser + " " + Request.Browser.Version + "/" + Request.Browser.Platform);
        }
    }
}