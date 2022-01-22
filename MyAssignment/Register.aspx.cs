using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;  
using System.Web.UI.WebControls;

namespace MyAssignment
{
    public partial class Register : System.Web.UI.Page
    {
        ConDB db= new ConDB();
        protected void Page_Load(object sender, EventArgs e)
        {


            //txtSearch.Text = "";
            //txtFullName.Text = "";
            //txtEmail.Text = "";
            //txtGender.Text = "";
            //txtUser.Text = "";
            //txtPass.Text = "";
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
           String sql = "select * from users where id ='"+txtSearch.Text.ToString() + "'";
            if(db.searchRes(sql) == true)
            {
                txtFullName.Text = db.fullname;  
                txtEmail.Text=db.email;
                txtGender.Text=db.gender;   
                txtUser.Text=db.user;
                txtPass.Text=db.pass;
            }
            else
            {
                lblAlert.Text = ("not Found");
                lblAlert.ForeColor = System.Drawing.Color.Red;

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
            String sql= "insert into users values('"+txtFullName.Text.ToString()+"', '"+txtEmail.Text.ToString()+"', '"+txtGender.Text.ToString()+"','"+txtUser.Text+"', '"+txtPass.Text+"')";
            db.louddate(sql,ref sV);
        }

        protected void sV_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["Roll"] = sV.SelectedRow.Cells[1].Text.ToString();
            txtFullName.Text = sV.SelectedRow.Cells[2].Text.ToString();
            txtEmail.Text = sV.SelectedRow.Cells[3].Text.ToString();
            txtGender.Text = sV.SelectedRow.Cells[4].Text.ToString();
            txtUser.Text = sV.SelectedRow.Cells[5].Text.ToString();
            txtPass.Text = sV.SelectedRow.Cells[6].Text.ToString();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            String sql = "update users set fname='" + txtFullName.Text.ToString() + "', email='" + txtEmail.Text.ToString() + "', gender ='" + txtGender.Text.ToString() + "', username='" + txtUser.Text + "', pswd ='" + txtPass.Text + "' where id = '"+txtSearch.Text+"'";
            db.louddate(sql, ref sV);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //Label1.Text = DateTime.Now.ToShortTimeString();

        }
    }
}