using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages.StaticContent.StepTables
{
    public partial class Stage9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveProject_Click(object sender, EventArgs e)
        {

        }

        protected void continueProject_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Stage10.aspx?projectId={Request.QueryString["projectId"]}");
        }
    }
}