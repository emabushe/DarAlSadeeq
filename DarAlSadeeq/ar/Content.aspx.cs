using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DarAlSadeeq.DA;

namespace DarAlSadeeq.ar
{
    public partial class Content : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int SectionID = Convert.ToInt32(Request.QueryString.Get("section"));
                int LevelID = Convert.ToInt32(Request.QueryString.Get("level"));
                int CategoryID = Convert.ToInt32(Request.QueryString.Get("category"));
                int PartID = Convert.ToInt32(Request.QueryString.Get("part"));
                int Content = Convert.ToInt32(Request.QueryString.Get("content"));
                divLevels.Visible = false;
                divArrow1.Visible = false;
                divCategories.Visible = false;
                divArrow2.Visible = false;
                divContentList.Visible = false;
                switch (SectionID)
                {
                    default:
                        break;
                    case 0:
                        break;
                    case 1:
                        lblSectionTitle.Text = "إنتاجاتنا";
                        divTitle.Attributes["class"] = "block-main no-margin";
                        DataTable dtLevels = DA.Content.GetLevels(SectionID);
                        if (dtLevels.Rows.Count > 0)
                        {
                            divLevels.Visible = true;
                            Page.Title = "دار الصديق :: " + dtLevels.Rows[0]["SectionTitleAR"].ToString() + " :: " + dtLevels.Rows[0]["SectionTitleEN"].ToString();
                            rptLevels.DataSource = dtLevels;
                            rptLevels.DataBind();
                        }
                        if (LevelID != 0)
                        {
                            DataTable dtContentList = DA.Content.GetContents(SectionID,LevelID);
                            if (dtContentList.Rows.Count > 0)
                            {
                                divArrow1.Visible = true;
                                divContentList.Visible = true;
                                rptContent.DataSource = dtContentList;
                                rptContent.DataBind();
                            }
                        }
                        break;
                }


            }
        }
    }
}