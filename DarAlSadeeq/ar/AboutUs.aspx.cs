using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class AboutUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindBody("about1");
        }
        void BindBody(string PageCode)
        {
            DataTable dt = DA.Content.GetAboutUs(PageCode);
            if(dt.Rows.Count>0)
            {
                lblBody.Text = dt.Rows[0]["PageBody"].ToString();
            }
            else
            {
                lblBody.Text = "";
            }
            
        }
        protected void btnServerSide_Click(object sender, EventArgs e)
        {
            subjectsContainer.Visible = true;
            subjectsArrow.Visible = true;
            BindBody(HD.Value);
        }
    }
}