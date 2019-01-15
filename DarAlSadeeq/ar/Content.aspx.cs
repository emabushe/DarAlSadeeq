using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
                int SubCategoryID = Convert.ToInt32(Request.QueryString.Get("subcategory"));
                int PartID = Convert.ToInt32(Request.QueryString.Get("part"));
                int ContentID = Convert.ToInt32(Request.QueryString.Get("content"));
                divLevels.Visible = false;
                divCategories.Visible = false;
                divSubCategories.Visible = false;
                divParts.Visible = false;
                divContentList.Visible = false;
                divLessons.Visible = false;
                DataTable dtLevels;
                DataTable dtCategories;
                DataTable dtSubCategories;
                DataTable dtParts;
                DataTable dtContentList;
                DataTable dtContent;
                switch (SectionID)
                {
                    default:
                        break;
                    case 0:
                        break;
                    case 1:
                        lblSectionTitle.Text = "إنتاجاتنا";
                        divTitle.Attributes["class"] = "block-main no-margin";
                        dtLevels = DA.Content.GetLevelsWithContents(SectionID);
                        if (dtLevels.Rows.Count > 0)
                        {
                            divLevels.Visible = true;
                            Page.Title = "دار الصديق :: " + dtLevels.Rows[0]["SectionTitleAR"].ToString() + " :: " + dtLevels.Rows[0]["SectionTitleEN"].ToString();
                            rptLevels.DataSource = dtLevels;
                            rptLevels.DataBind();
                        }
                        if (LevelID != 0)
                        {
                            dtCategories = DA.Content.GetCategoriesWithContents(SectionID, LevelID);
                            if (dtCategories.Rows.Count > 0)
                            {
                                divCategories.Visible = true;
                                rptCategories.DataSource = dtCategories;
                                rptCategories.DataBind();
                                if (CategoryID != 0)
                                {
                                    dtContentList = DA.Content.GetContents(SectionID, LevelID);
                                    if (dtContentList.Rows.Count > 0)
                                    {
                                        divContentList.Visible = true;
                                        rptContent.DataSource = dtContentList;
                                        rptContent.DataBind();
                                    }
                                }

                            }
                        }
                        break;
                    case 2:
                        lblSectionTitle.Text = "المنهاج الإلكتروني";
                        divTitle.Attributes["class"] = "block-main block2 no-margin";
                        dtLevels = DA.Content.GetLevelsWithContents(SectionID);
                        if (dtLevels.Rows.Count > 0)
                        {
                            divLevels.Visible = true;
                            Page.Title = "دار الصديق :: " + dtLevels.Rows[0]["SectionTitleAR"].ToString() + " :: " + dtLevels.Rows[0]["SectionTitleEN"].ToString();
                            rptLevels.DataSource = dtLevels;
                            rptLevels.DataBind();
                        }
                        if (LevelID != 0)
                        {
                            dtCategories = DA.Content.GetCategoriesWithContents(SectionID, LevelID);
                            if (dtCategories.Rows.Count > 0)
                            {
                                divCategories.Visible = true;
                                rptCategories.DataSource = dtCategories;
                                rptCategories.DataBind();
                                if (CategoryID != 0)
                                {
                                    dtParts = DA.Content.GetPartsWithContents(SectionID, LevelID);
                                    if (dtParts.Rows.Count > 0)
                                    {
                                        divParts.Visible = true;
                                        rptParts.DataSource = dtParts;
                                        rptParts.DataBind();
                                        if (PartID != 0)
                                        {
                                            dtContentList = DA.Content.GetContents(SectionID, LevelID, -1, -1, PartID);
                                            if (dtContentList.Rows.Count > 0)
                                            {
                                                divLessons.Visible = true;
                                                rptLessons.DataSource = dtContentList;
                                                rptLessons.DataBind();
                                            }
                                        }
                                    }
                                    
                                }
                            }
                        }
                        break;
                    case 3:
                        lblSectionTitle.Text = "منهاج المستوى الأول";
                        divTitle.Attributes["class"] = "block-main block3 no-margin";
                        dtLevels = DA.Content.GetLevelsWithContents(SectionID);
                        if (dtLevels.Rows.Count > 0)
                        {
                            divLevels.Visible = true;
                            Page.Title = "دار الصديق :: " + dtLevels.Rows[0]["SectionTitleAR"].ToString() + " :: " + dtLevels.Rows[0]["SectionTitleEN"].ToString();
                            rptLevels.DataSource = dtLevels;
                            rptLevels.DataBind();
                        }
                        if (LevelID != 0)
                        {
                            dtCategories = DA.Content.GetCategoriesWithContents(SectionID, LevelID);
                            if (dtCategories.Rows.Count > 0)
                            {
                                divCategories.Visible = true;
                                rptCategories.DataSource = dtCategories;
                                rptCategories.DataBind();
                                switch (CategoryID)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        dtSubCategories = DA.Content.GetSubCategoriesWithContents(SectionID, LevelID, CategoryID);
                                        divSubCategories.Visible = true;
                                        rptSubCategories.DataSource = dtSubCategories;
                                        rptSubCategories.DataBind();
                                        if (SubCategoryID != 0)
                                        {
                                            dtContentList = DA.Content.GetContents(SectionID, LevelID, CategoryID, SubCategoryID);
                                            divContentList.Visible = true;
                                            rptContent.DataSource = dtContentList;
                                            rptContent.DataBind();
                                        }
                                        break;
                                     default:
                                        dtContentList = DA.Content.GetContents(SectionID, LevelID, CategoryID);
                                        divContentList.Visible = true;
                                        rptContent.DataSource = dtContentList;
                                        rptContent.DataBind();
                                        break;
                                }
                            }
                        }
                        break;
                    case 4:
                        lblSectionTitle.Text = "الكتب المطبوعة";
                        divTitle.Attributes["class"] = "block-main block4 no-margin";
                        dtLevels = DA.Content.GetLevelsWithContents(SectionID);
                        if (dtLevels.Rows.Count > 0)
                        {
                            divLevels.Visible = true;
                            Page.Title = "دار الصديق :: " + dtLevels.Rows[0]["SectionTitleAR"].ToString() + " :: " + dtLevels.Rows[0]["SectionTitleEN"].ToString();
                            rptLevels.DataSource = dtLevels;
                            rptLevels.DataBind();
                        }
                        if (LevelID != 0)
                        {
                            dtParts = DA.Content.GetPartsWithContents(SectionID, LevelID);
                            if (dtParts.Rows.Count > 0)
                            {
                                divParts.Visible = true;
                                rptParts.DataSource = dtParts;
                                rptParts.DataBind();
                                if (PartID != 0)
                                {
                                    dtContentList = DA.Content.GetContents(SectionID, LevelID, -1, -1, PartID);
                                    divContentList.Visible = true;
                                    rptContent.DataSource = dtContentList;
                                    rptContent.DataBind();
                                }
                            }
                        }
                        break;
                    case 5:
                        lblSectionTitle.Text = "القصص";
                        divTitle.Attributes["class"] = "block-main block5 no-margin";
                        dtLevels = DA.Content.GetLevelsWithContents(SectionID);
                        if (dtLevels.Rows.Count > 0)
                        {
                            divLevels.Visible = true;
                            Page.Title = "دار الصديق :: " + dtLevels.Rows[0]["SectionTitleAR"].ToString() + " :: " + dtLevels.Rows[0]["SectionTitleEN"].ToString();
                            rptLevels.DataSource = dtLevels;
                            rptLevels.DataBind();
                            if (LevelID != 0)
                            {

                                dtContentList = DA.Content.GetContents(SectionID, LevelID);
                                if (dtContentList.Rows.Count > 0)
                                {
                                    divContentList.Visible = true;
                                    rptContent.DataSource = dtContentList;
                                    rptContent.DataBind();
                                }
                            }
                        }
                        break;
                    case 7:
                        lblSectionTitle.Text = "للمعلم";
                        divTitle.Attributes["class"] = "block-main block4 no-margin";
                        dtLevels = DA.Content.GetLevelsWithContents(SectionID);
                        if (dtLevels.Rows.Count > 0)
                        {
                            divLevels.Visible = true;
                            Page.Title = "دار الصديق :: " + dtLevels.Rows[0]["SectionTitleAR"].ToString() + " :: " + dtLevels.Rows[0]["SectionTitleEN"].ToString();
                            rptLevels.DataSource = dtLevels;
                            rptLevels.DataBind();
                        }
                        if (LevelID != 0)
                        {
                            dtParts = DA.Content.GetCategoriesWithContents(SectionID, LevelID);
                            if (dtParts.Rows.Count > 0)
                            {
                                divCategories.Visible = true;
                                rptCategories.DataSource = dtParts;
                                rptCategories.DataBind();
                                if (CategoryID != 0)
                                {
                                    dtContentList = DA.Content.GetContents(SectionID, LevelID, CategoryID);
                                    divContentList.Visible = true;
                                    rptContent.DataSource = dtContentList;
                                    rptContent.DataBind();
                                }
                            }
                        }
                        break;
                }
            }
        }
    }
}