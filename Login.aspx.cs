using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetCommunity
{
    public partial class page1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from login where (username=@uid and password=@pwd) and status='enable'", conn);
            cmd.Parameters.AddWithValue("@uid", name.Text);
            cmd.Parameters.AddWithValue("@pwd", pwd.Text);
            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            conn.Close();
            if(i==0)
            {
                lblmsg.Text = "wrong credentils";
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("select * from login where username='" + name.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                Session["id"] = ds.Tables[0].Rows[0][0];
                Session["name"] = ds.Tables[0].Rows[0][1];
                Response.Redirect("./Home.aspx");
            }

           
        }
    }
}