using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CSSAnimateTest
{
    public partial class _default : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=HS300MINECR\TECHSQL;Initial Catalog=White;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("SELECT txt_Name as Name, txt_Address AS Address, txt_City as City, txt_State as State, txt_Zip as Zip FROM T_Address", cn);
            DataSet ds = new DataSet();

            ad.Fill(ds);
            //don't forget to add the Gridview to your page
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }

      

    }
}