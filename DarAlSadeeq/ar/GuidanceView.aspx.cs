using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class GuidanceView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int ID = Convert.ToInt32(Request.QueryString.Get("mid"));
                DataTable dt = DA.Content.GetGuidance(ID);
                if (dt.Rows.Count > 0)
                {
                    ImgGuidance.ImageUrl = dt.Rows[0]["Pic"].ToString();
                    GuidanceType.InnerText = dt.Rows[0]["Type"].ToString();
                    GuidanceType.HRef = "GuidanceList.aspx?sid=" + dt.Rows[0]["ErshadID"].ToString();
                    lblGuidanceTitle.Text = dt.Rows[0]["ErshadSub"].ToString();
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                }
                else
                {
                    lblBody.Visible = true;
                }
            }
        }
    }
}