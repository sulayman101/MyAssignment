using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyAssignment.pages
{
    public partial class Login : System.Web.UI.Page
    {
        ConDB db = new ConDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSingIn_Click(object sender, EventArgs e)
        {
            String sql = "Select * from users where username='"+ txtUser.Text +"' and pswd ='"+txtPass.Text+"'";
            if (db.login(sql))
            {
                Response.Redirect("Viewtable.aspx");
            }
            else
            {
                txtUser.BorderColor =System.Drawing.Color.Red;
                txtPass.BorderColor = System.Drawing.Color.Red;

            }

        }
    }
}