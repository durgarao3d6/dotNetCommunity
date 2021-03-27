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
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        LinkButton lbtn;
        public void MainData()
        {
            foreach(GridViewRow r in GridView1.Rows)
            {
                lbtn = (LinkButton)r.FindControl("LinkStatus");
                if(lbtn.Text=="pending")
                {
                    lbtn.Text = "Approve";
                }
                else if(lbtn.Text=="Enable")
                {
                    lbtn.Text = "Block";
                }
                else
                {
                    lbtn.Text = "blocked";
                }
            }
        }
        public void BindData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Login", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
            MainData();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string st = "";
            int id = 0;
            string name = "Enable";
            if(e.CommandName=="status")
            {
                id = Convert.ToInt32(e.CommandArgument);
            }
            SqlCommand cmd = new SqlCommand($"select status from login where loginid={id} ", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                st = dr[0].ToString();
            }
            conn.Close();
            if(st=="Enable")
            {
                name = "Disable";
            }
            else
            {
                name = "Enable";
            }
            SqlCommand cmd1 = new SqlCommand($"update login set status=@st where loginid=@id",conn);
            cmd1.Parameters.AddWithValue("@st", name);
            cmd1.Parameters.AddWithValue("@id", id);
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
            BindData();
            MainData();

                
        }
    }
}