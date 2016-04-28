using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSSAnimateTest
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text = "Enter Your Name";
            if (!((Page)System.Web.HttpContext.Current.CurrentHandler).IsPostBack)
            {
                Literal1.Text = "<h1>Hello from the Literal Side.</h1>";
                Greeting.Style.Add("background-color", "lightblue");
                Greeting.Style.Add("position", "absolute");
                Greeting.Style.Add("top", "80px");
                Greeting.Style.Add("left", "75px");
            }
            else
            {
                String stuff = TextBox1.Text;
                Literal1.Text = "<h1>Hello " + stuff + " </h1>"; 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SearchBox.Style.Add("left", "144px");
            SearchBox.Visible = false;
            Greeting.Style.Add("background-color", "lightgreen");
            Greeting.Style.Add("position", "absolute");
            Greeting.Style.Add("top", "500px");
            Greeting.Style.Add("left", "275px");
        }


    }
}