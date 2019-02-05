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
                int SubSectionID = Convert.ToInt32(Request.QueryString.Get("subsection"));
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
                DataTable dtContentList;
                switch (SectionID)
                {
                    default:
                        break;
                    case 0:
                        break;
                    case 1:
                        lblSectionTitle.Text = "إنتاجاتنا";
                        divTitle.Attributes["class"] = "block-main no-margin";
                        if (ShowSubSections(SectionID))
                        {
                            switch (SubSectionID)
                            {

                                case 0:
                                    break;
                                case 1:
                                    if (ShowParts(SectionID, -1, SubSectionID))
                                    {
                                        if (PartID != 0)
                                        {
                                            dtContentList = DA.Content.GetContents(SectionID, -1, -1, -1, PartID, SubSectionID);
                                            if (dtContentList.Rows.Count > 0)
                                            {
                                                divLessons.Visible = true;
                                                rptLessons.DataSource = dtContentList;
                                                rptLessons.DataBind();
                                            }
                                        }
                                    }
                                    break;
                                case 2:
                                    if (ShowLevels(SectionID, SubSectionID))
                                    {
                                        if (LevelID == 0)
                                            break;
                                        else if(LevelID>8)
                                        {
                                            ShowContentList(SectionID, LevelID, -1, -1, -1, SubSectionID);
                                        }
                                        else if (LevelID <= 8)
                                        {
                                            if (ShowParts(SectionID, LevelID, SubSectionID))
                                            {
                                                if (PartID != 0)
                                                {
                                                    ShowContentList(SectionID, LevelID, -1, -1, PartID, SubSectionID);
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    ShowCategories(SectionID, -1, SubSectionID);
                                    if (CategoryID != 0)
                                    {
                                        if(CategoryID==1)
                                        {
                                            if (ShowSubCategories(SectionID, -1, CategoryID, SubSectionID))
                                            {
                                                if (SubCategoryID != 0)
                                                {
                                                    ShowContentList(SectionID, -1, CategoryID, SubCategoryID, -1, SubSectionID);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            ShowContentList(SectionID, -1, CategoryID, -1, -1, SubSectionID);
                                        }
                                       
                                    }

                                    break;
                                default:
                                    if (ShowLevels(SectionID, SubSectionID))
                                    {
                                        if (LevelID != 0)
                                        {
                                            ShowContentList(SectionID, LevelID, -1, -1, -1, SubSectionID);
                                        }
                                    }
                                    break;
                            }

                        }
                        break;
                    case 2:
                        lblSectionTitle.Text = "المنهاج الإلكتروني";
                        divTitle.Attributes["class"] = "block-main block2 no-margin";
                        ShowLevels(SectionID);
                        if (LevelID != 0)
                        {
                            if (ShowCategories(SectionID, LevelID))
                            {
                                if (CategoryID != 0)
                                {
                                    if (ShowParts(SectionID, LevelID))
                                    {
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
                        ShowLevels(SectionID);
                        if (LevelID != 0)
                        {
                            if (ShowCategories(SectionID, LevelID))
                            {
                                switch (CategoryID)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        ShowSubCategories(SectionID, LevelID, CategoryID);
                                        if (SubCategoryID != 0)
                                        {
                                            ShowContentList(SectionID, LevelID, CategoryID, SubCategoryID);
                                        }
                                        break;
                                    default:
                                        ShowContentList(SectionID, LevelID, CategoryID);
                                        break;
                                }
                            }
                        }
                        break;
                    case 4:
                        lblSectionTitle.Text = "الكتب المطبوعة";
                        divTitle.Attributes["class"] = "block-main block4 no-margin";
                        ShowLevels(SectionID);
                        if (LevelID != 0)
                        {
                            if (ShowParts(SectionID, LevelID))
                            {
                                if (PartID != 0)
                                {
                                    ShowContentList(SectionID, LevelID, -1, -1, PartID);
                                }
                            }
                        }
                        break;
                    case 5:
                        lblSectionTitle.Text = "القصص";
                        divTitle.Attributes["class"] = "block-main block5 no-margin";
                        ShowLevels(SectionID);
                        if (LevelID != 0)
                        {
                            ShowContentList(SectionID, LevelID);
                        }
                        break;
                    case 7:
                        lblSectionTitle.Text = "للمعلم";
                        divTitle.Attributes["class"] = "block-main block4 no-margin";
                        ShowLevels(SectionID);
                        if (LevelID != 0)
                        {
                            if (CategoryID != 0)
                            {
                                ShowContentList(SectionID, LevelID, CategoryID);
                            }
                        }
                        break;
                }
            }
        }
        public bool ShowSubSections(int SectionID = -1)
        {
            DataTable dtSubSections = DA.Content.GetSubSectionsWithContents(SectionID);
            if (dtSubSections.Rows.Count > 0)
            {
                divSubSections.Visible = true;
                Page.Title = "دار الصديق :: " + dtSubSections.Rows[0]["SubSectionTitleAR"].ToString() + " :: " + dtSubSections.Rows[0]["SubSectionTitleEN"].ToString();
                rptSubSections.DataSource = dtSubSections;
                rptSubSections.DataBind();
                return true;
            }
            return false;
        }
        public bool ShowLevels(int SectionID = -1, int SubSectionID = -1)
        {
            DataTable dtLevels = DA.Content.GetLevelsWithContents(SectionID, SubSectionID);
            if (dtLevels.Rows.Count > 0)
            {
                divLevels.Visible = true;
                Page.Title = "دار الصديق :: " + dtLevels.Rows[0]["SectionTitleAR"].ToString() + " :: " + dtLevels.Rows[0]["SectionTitleEN"].ToString();
                rptLevels.DataSource = dtLevels;
                rptLevels.DataBind();
                return true;
            }
            return false;
        }
        public bool ShowCategories(int SectionID = -1, int LevelID = -1, int SubSectionID = -1)
        {
            DataTable dtCategories = DA.Content.GetCategoriesWithContents(SectionID, LevelID, SubSectionID);
            if (dtCategories.Rows.Count > 0)
            {
                divCategories.Visible = true;
                rptCategories.DataSource = dtCategories;
                rptCategories.DataBind();
                return true;
            }
            return false;
        }
        public bool ShowSubCategories(int SectionID = -1, int LevelID = -1, int CategoryID = -1, int SubSectionID = -1)
        {
            DataTable dtSubCategories = DA.Content.GetSubCategoriesWithContents(SectionID, LevelID, CategoryID, SubSectionID);
            if (dtSubCategories.Rows.Count > 0)
            {
                divSubCategories.Visible = true;
                rptSubCategories.DataSource = dtSubCategories;
                rptSubCategories.DataBind();
                return true;
            }
            return false;
        }
        public bool ShowParts(int SectionID, int LevelID = -1, int SubsectionID = -1)
        {
            DataTable dtParts = DA.Content.GetPartsWithContents(SectionID, LevelID, SubsectionID);
            if (dtParts.Rows.Count > 0)
            {
                divParts.Visible = true;
                rptParts.DataSource = dtParts;
                rptParts.DataBind();
                return true;
            }
            return false;
        }
        public bool ShowContentList(int SectionID = -1, int LevelID = -1, int CategoryID = -1, int SubCategoryID = -1, int PartID = -1, int SubSectionID = -1)
        {
            DataTable dtContentList = DA.Content.GetContents(SectionID, LevelID, CategoryID, SubCategoryID, PartID, SubSectionID);
            if (dtContentList.Rows.Count > 0)
            {
                divContentList.Visible = true;
                rptContent.DataSource = dtContentList;
                rptContent.DataBind();
                return true;
            }
            return false;
        }
    }
}