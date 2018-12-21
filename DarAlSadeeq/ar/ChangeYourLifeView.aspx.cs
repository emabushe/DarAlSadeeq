using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class ChangeYourLifeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int ID = Convert.ToInt32(Request.QueryString.Get("mid"));
                DataTable dt = DA.Content.ChangeYourLifeView(ID);
                if (dt.Rows.Count > 0)
                {
                    ImgChangeYourLife.ImageUrl = dt.Rows[0]["Pic"].ToString();
                    ChangeYourLifeType.InnerText = dt.Rows[0]["Type"].ToString();
                    ChangeYourLifeType.HRef = "ChangeYourLifeList.aspx?sid=" + dt.Rows[0]["SubID"].ToString();
                    lblGuidanceTitle.Text = dt.Rows[0]["Title"].ToString();
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