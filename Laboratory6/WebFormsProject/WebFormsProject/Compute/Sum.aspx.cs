using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsProject.Compute
{
    public partial class Sum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumNumbers(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Number3.Text = SumOperations.Add(Convert.ToInt32(Number1.Text),
                                                 Convert.ToInt32(Number2.Text),
                                                 Convert.ToInt32(Number3.Text)).ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}