using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fhl165033213.WebUI
{
    public partial class register_success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lb1_Welcome.Text = Session["username"] + "o " + Session["sex"] + ",欢迎您注册成功！";
            TBx_Info.Text += "密码：" + Session["password"] + "\r\n";
            TBx_Info.Text += "出生日期：" + Session["birthday"] + "\r\n";
            TBx_Info.Text += "学历：" + Session["degree"] + "\r\n";
            TBx_Info.Text += Session["question"].ToString() + Session["answer"] + "\r\n";
            TBx_Info.Text += "兴趣爱好：" + Session["hobbies"];


        }
    }
}