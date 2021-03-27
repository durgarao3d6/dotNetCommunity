using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DotNetCommunity
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        SqlCommand cmd;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                

            }
        }

        private int AutoLogId()
        {
            cmd = new SqlCommand("select ISNULL(MAX(LOGINID),0) FROM Login", conn);
            conn.Open();
            int eno = (int)cmd.ExecuteScalar();
            conn.Close();
            eno++;
            return eno;
        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            int eno = AutoLogId();
            cmd = new SqlCommand("insert into login values (@lid,@nname,@uname,@pwd,@que,@ans,@sts)", conn);
            cmd.Parameters.AddWithValue("@lid",eno);
            cmd.Parameters.AddWithValue("@nname",txtusername.Text);
            cmd.Parameters.AddWithValue("@uname",txtuname.Text);
            cmd.Parameters.AddWithValue("@pwd",txtpwd.Text);
            cmd.Parameters.AddWithValue("@que",DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@ans", txtanswer.Text) ;
            cmd.Parameters.AddWithValue("@sts","inactive");
            conn.Open();
            int i=cmd.ExecuteNonQuery();
            conn.Close();
            if(i==1)
            {
                Label1.Text = "you registered sucessfuly";
            }
            else

            {
                Label1.Text = "registration failed";
            }

        }
    }
}