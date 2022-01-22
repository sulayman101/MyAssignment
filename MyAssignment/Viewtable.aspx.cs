using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyAssignment
{
    public partial class View_Tables : System.Web.UI.Page
    {
        ConDB db = new ConDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = "titles";
            db.louddate(sql, ref AllView);
            //lblNoVUser.Text = db.username;
        }

        protected void AllView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["ID"] = AllView.SelectedRow.Cells[1].Text.ToString();
            string sql = " delete  users where ID = '" + Session["ID"] + "'";
            db.inupdel(sql);
            db.louddate("Select * from users", ref AllView);
        }

        protected void btnSeach(object sender, EventArgs e)
        {
            String sql = "select * from users where id='" + txtSeach.Text + "'";
            db.searchRes(sql);
            if (db.searchRes(sql) == true)
            {
                db.louddate("Select fname, email, gender,username,pswd from users where id='" + txtSeach.Text + "'", ref AllView);
                lblResualt.Visible = false;
            }
            else
            {
                lblResualt.Text = ("Not Found");
            }
        }
    }
}