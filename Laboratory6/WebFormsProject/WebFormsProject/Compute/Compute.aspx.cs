using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsProject.Compute
{
    public partial class Compute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Test(object sender, EventArgs e)
        {
            if (IsValid)
            {
                if (WordManipulationOperations.IsPalimdorme(Word.Text))
                {
                    Result.Text = "yes";
                }
                else
                {
                    Result.Text = "no";
                }
            }
        }
    }
}