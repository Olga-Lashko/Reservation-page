using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx09Reservation
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sets the text of the label in the footer to the current year
            lblYear.Text = DateTime.Today.Year.ToString();
        }
    }
}
