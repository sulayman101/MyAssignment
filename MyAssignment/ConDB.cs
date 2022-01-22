using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace MyAssignment
{

    public class ConDB
    {
        public String fullname,email,gender,user,pass;
        public String username= "Suldanka";
        SqlConnection con = new SqlConnection("Data Source=SQL5079.site4now.net;Initial Catalog=db_a7f074_somali;User Id=db_a7f074_somali_admin;Password=somali123");

        public bool login(String sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public void louddate(String sql,ref GridView gvList)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "users");
            gvList.DataSource = ds.Tables["users"];
            gvList.DataBind();
            con.Close();
        }
        public void inupdel(String sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public String fullName;
        public bool searchRes(String sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader da = cmd.ExecuteReader();
                  if (da.Read())
            {  
                fullname = da["fname"].ToString();
                email = da["email"].ToString();
                gender = da["gender"].ToString();
                user = da["username"].ToString();
                pass = da["pswd"].ToString();
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
           
        }
      
    }
}