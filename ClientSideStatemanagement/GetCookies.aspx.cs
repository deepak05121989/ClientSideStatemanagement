using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientSideStatemanagement
{
    public partial class GetCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //HttpCookie cookies = Request.Cookies["userInfo"];
            //if (cookies != null)
            //{
            //    TextBox1.Text = cookies["name"].ToString();
            //    TextBox2.Text = cookies["mobile"].ToString();
            //    TextBox3.Text = cookies["email"].ToString();
            //    Label1.Text = "Add cooies successfuly";

            //}
            //else
            //{
            //    Label1.Text = "cookies data not found";
            //}

            //retrive data using query string
            if (Request.QueryString["Id"] != null)
            {
                TextBox1.Text = Request.QueryString["Id"].ToString();
                TextBox2.Text = Request.QueryString["name"].ToString();
                TextBox3.Text = Request.QueryString["mobile"].ToString();
                Label1.Text = "Get QueryString data successfuly";

            }
            else
            {
                Label1.Text = "QueryString data not found";
            }


        }
    }
}