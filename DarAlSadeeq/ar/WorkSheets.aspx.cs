using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class WorkSheets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["IsGame"] = "";
            int ClassID = Convert.ToInt32(Request.QueryString.Get("CID"));
            if (ClassID != 0)
            {
                subjectsContainer.Visible = true;
                subjectsArrow.Visible = true;
                getSubjects(ClassID);
            }
            else
            {
                subjectsContainer.Visible = false;
                subjectsArrow.Visible = false;
            }
        }
        public void getSubjects(int ClassID)
        {
            RepeaterSubjects.DataSource = DA.Content.ListSubjects(ClassID);
            RepeaterSubjects.DataBind();
        }
        protected void btnServerSide_Click(object sender, EventArgs e)
        {
            subjectsContainer.Visible = true;
            subjectsArrow.Visible = true;
            getSubjects(Convert.ToInt32(HD.Value));
        }
    }

}