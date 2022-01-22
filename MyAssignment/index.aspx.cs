using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyAssignment
{
    public partial class Home : System.Web.UI.Page
    {
        ConDB db = new ConDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNoVUser.Text = db.username;
        }
    }
}