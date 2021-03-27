using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DotNetCommunity
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        SqlCommand cmd;
        public int qno;
        protected void Page_Load(object sender, EventArgs e)
        {
            lbluser.Text ="<i class='fa fa-user' style='font-size:25px'></i>"+ Session["name"].ToString();
           
        }
        private int AutoLogId()
        {
            cmd = new SqlCommand("select ISNULL(MAX(QuestionID),0) FROM Forum", conn);
            conn.Open();
            qno = (int)cmd.ExecuteScalar();
            conn.Close();
            qno++;
            return qno;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int qid = AutoLogId();
            cmd = new SqlCommand("insert into Forum values('" + qid + "','" + TextBox1.Text + "','" + Session["id"] + "')", conn);
            conn.Open();
             int i=cmd.ExecuteNonQuery();
            conn.Close();
            if(i==1)
            {
                lblmsg.ForeColor = System.Drawing.Color.Green;
                lblmsg.Text = "Your query is posted sucessfuly";
            }
            else
            {
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "sorry posting failed try again";

            }
        }
    }
}