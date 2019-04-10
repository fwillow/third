using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fhl165033213.WebUI
{
    public partial class menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Response.Write("<li><strong>图书分类</strong></li>");
                Response.Write("<li><a href='book.html' target='main'>C语言程序设计</a></li>");
                Response.Write("<li><a href='book.html' target='main'>Java开发</a></li>");
                Response.Write("<li><a href='bookDb.html' target='main'>数据库</a></li>");
                Response.Write("<li><a href='bookWeb.html' target='main'>网页编程</a></li>");
            }
        }
    }
}