using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace fhl165033213.WebUI
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CBx_LicenseAgreement_CheckedChanged(object sender, EventArgs e)
        {
            if (CBx_LicenseAgreement.Checked)
            {
                Btn_Submit.Enabled = true;
                Btn_Submit.ForeColor = Color.FromName("#009900");

            }
            else
            {

                Btn_Submit.Enabled = false;
                Btn_Submit.ForeColor = Color.Gray;

            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

            TBx_Date.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void Btn_Submit_Click(object sender, EventArgs e)
        {
            Session["username"] = Request.Form["TBx_Usr"];
            if (RBtn_male.Checked)
            {
                Session["sex"] = "先生";
            }
            else
            {
                Session["sex"] = "女士";

            }
            Session["password"] = Request.Form["TBx_Pwd"];
            Session["birthday"] = Request.Form["TBx_Date"];
            Session["degree"] = ListBox1.SelectedValue;
            Session["answer"] = TBx_Answer.Text;
            Session["hobbies"] = (CheckBox1.Checked ? "唱歌" : "") + (CheckBox2.Checked ? "阅读" : "") + (CheckBox3.Checked ? "跳舞" : "") + (CheckBox4.Checked ? "游泳" : "") + (CheckBox5.Checked ? "旅游" : "");
            Response.Redirect("register_success.aspx");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedValue)
            {
                case "1":
                    Lbl_Answer.Text = "您母亲的生日：  ";
                    break;
                case "2":
                    Lbl_Answer.Text = "你喜欢的书：  ";
                    break;
                case "3":
                    Lbl_Answer.Text = "你难忘的日子：  ";
                    break;

            }
            Session["question"] = Lbl_Answer.Text;
        }


    }
}