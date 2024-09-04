using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             Label lblty = new Label();
             lblty.Text = "enter the text";
             lblty.BackColor = System.Drawing.Color.Blue;
             lblty.Font.Bold = true;
             lblty.ForeColor = System.Drawing.Color.White;
             this.form1.Controls.Add(lblty);

             Button b1 = new Button();
             b1.Text = "label on click";
             //b1.BackColor = System.Drawing.Color.Yellow;
             //b1.Font.Bold = true;
             this.form1.Controls.Add(b1);
            




        }
    }
}