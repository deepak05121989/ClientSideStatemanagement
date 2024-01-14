using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientSideStatemanagement
{
    public partial class CookiesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["name"] != null)
            {
                Label1.Text = ViewState["name"].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //HttpCookie cookie = new HttpCookie("userInfo");
            //cookie["name"]=TextBox1.Text;
            //cookie["mobile"] = TextBox2.Text;
            //cookie["email"] = TextBox3.Text;
            //cookie.Expires= DateTime.Now.AddDays(1);
            //Response.Cookies.Add(cookie);
           // Label1.Text = "Add cooies successfuly";
            //QueryString
           // Response.Redirect("GetCookies.aspx?Id=4474&name=" + TextBox1.Text+"&mobile="+TextBox2.Text);


            ViewState["name"] = TextBox1.Text;

           


            
        }
    }
}