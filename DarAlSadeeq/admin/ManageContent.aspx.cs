using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DarAlSadeeq.DA;
using System.Data;
using ICSharpCode.SharpZipLib.Zip;

namespace DarAlSadeeq.admin
{
    public partial class ManageContent : System.Web.UI.Page
    {
        public static string coverImagePath;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadContent();
            }
        }
        public void LoadContent()
        {
            GetSections(drpSections, -1, "اختر");
            GetSections(drpEditSections, -1, "الكل");
            GetSections(drpSectionsEdit, -1, "اختر");
            GetSubSections(DrpSubSections, -1, "غير محدد");
            GetSubSections(DrpSubSectionsEdit, -1, "الكل");
            GetSubSections(DrpEditSubSections, -1, "اختر");
            GetLevels(DrpLevels, -1, "غير محدد");
            GetLevels(drpEditLevels, -1, "الكل");
            GetLevels(drpLevelsEdit, -1, "اختر");
            GetLevels(drpLevelsDelete, -1, "اختر");
            GetCategories(DrpDwnCategories, -1, "غير محدد");
            GetCategories(drpEditCategories, -1, "الكل");
            GetCategories(drpCategoriesEdit, -1, "اختر");
            GetCategories(drpCategoriesDelete, -1, "اختر");
            GetSubCategories(drpSubCategories, -1, "غير محدد");
            GetSubCategories(drpEditSubCategories, -1, "الكل");
            GetParts(drpParts, -1, "غير محدد");
            GetParts(drpEditParts, -1, "الكل");
        }
        protected void btn_save_Click(object sender, EventArgs e)
        {
            int SubSectionID = (drpSections.SelectedItem.Value == "1") ? Convert.ToInt32(DrpSubSections.SelectedItem.Value) : -1;
            string contentPath = "";
            if (drpContentType.SelectedItem.Text == "Youtube")
            {
                contentPath = txtYoutube.Text;
            }
            else
            {
                contentPath = "~/content/" + DrpLevels.SelectedValue + "/" + DrpDwnCategories.SelectedValue +
               "/" + drpParts.SelectedValue + "/" + txtContentTitleAR.Text + "/" + drpContentType.SelectedValue;
                if (!Directory.Exists(Server.MapPath(contentPath)))
                    Directory.CreateDirectory(Server.MapPath(contentPath));
                if (drpContentType.SelectedItem.Text == "HTML Page")
                {
                    string dirName = "";
                    string zippedFile = (Server.MapPath(contentPath+"/" + contentFileUploader.FileName));
                    contentFileUploader.SaveAs(zippedFile);
                    using (ZipInputStream s = new ZipInputStream(File.OpenRead(zippedFile)))
                    {
                        ZipEntry theEntry;
                        while ((theEntry = s.GetNextEntry()) != null)
                        {
                            string directoryName = Path.GetDirectoryName(theEntry.Name);
                            string fileName = Path.GetFileName(theEntry.Name);
                            // create directory
                            if (directoryName.Length > 0)
                            {
                                dirName = new DirectoryInfo(directoryName).Name;
                                Directory.CreateDirectory(Server.MapPath(contentPath + "\\" + dirName));
                            }
                            if (fileName != String.Empty)
                            {
                                using (FileStream streamWriter = File.Create(Server.MapPath(contentPath + "\\"+theEntry.Name)))
                                {

                                    int size = 2048;
                                    byte[] data = new byte[2048];
                                    while (true)
                                    {
                                        size = s.Read(data, 0, data.Length);
                                        if (size > 0)
                                        {
                                            streamWriter.Write(data, 0, size);
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (File.Exists(zippedFile))
                        File.Delete(zippedFile);
                }
                coverFileUploader.SaveAs(Server.MapPath(contentPath + "/cover" + Path.GetExtension(coverFileUploader.FileName)));
                HttpFileCollection fileCollection = Request.Files;
                if (drpContentType.SelectedItem.Text == "Pages")
                {
                    for (int i = 0; i < fileCollection.Count; i++)
                    {
                        HttpPostedFile uploadfile = fileCollection[i];
                        string fileName = Path.GetFileName(uploadfile.FileName);
                        if (uploadfile.ContentLength > 0)
                        {
                            uploadfile.SaveAs(Server.MapPath(contentPath + "/" + fileName));
                        }
                    }
                }
                else
                {
                    contentFileUploader.SaveAs(Server.MapPath(contentPath + "/" + contentFileUploader.FileName));
                }
            }

            if (DA.Content.InsertContent(txtContentTitleAR.Text.Trim(), txtContentTitleEN.Text.Trim(), drpContentType.SelectedItem.Text,
                contentPath, Convert.ToInt32(DrpLevels.SelectedValue), Convert.ToInt32(DrpDwnCategories.SelectedValue),
                Convert.ToInt32(drpParts.SelectedValue), Convert.ToInt32(drpSections.SelectedValue), txtDescription.Text,
                contentPath + "/cover" + Path.GetExtension(coverFileUploader.FileName), Convert.ToInt32(drpSubCategories.SelectedValue),
                SubSectionID))
            {
                lblContentResult.ForeColor = Color.Green;
                lblContentResult.Visible = true;
            }
            else
            {
                lblContentResult.ForeColor = Color.Red;
                lblContentResult.Visible = true;
                lblContentResult.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void btnSaveNewSection_Click(object sender, EventArgs e)
        {
            if (DA.Content.InsertSection(txtSectionTitleAR.Text.Trim(), txtSectionTitleEN.Text.Trim()))
            {
                lblSectionsResults.ForeColor = Color.Green;
                lblSectionsResults.Visible = true;
                lblSectionsResults.Text = "تمت الإضافة بنجاح";
            }
            else
            {
                lblSectionsResults.ForeColor = Color.Red;
                lblSectionsResults.Visible = true;
                lblSectionsResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void btnEditSection_Click(object sender, EventArgs e)
        {
            if (DA.Content.UpdateSection(Convert.ToInt32(drpSectionsEdit.SelectedValue), txtSectionTitleAREdit.Text.Trim(), txtSectionTitleENEdit.Text.Trim()))
            {
                lblSectionsResults.ForeColor = Color.Green;
                lblSectionsResults.Visible = true;
                lblSectionsResults.Text = "تمت التعديل بنجاح";
            }
            else
            {
                lblSectionsResults.ForeColor = Color.Red;
                lblSectionsResults.Visible = true;
                lblSectionsResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void btnDeleteSection_Click(object sender, EventArgs e)
        {
            if (DA.Content.DeleteSection(Convert.ToInt32(drpSectionsEdit.SelectedValue)))
            {
                lblSectionsResults.ForeColor = Color.Green;
                lblSectionsResults.Visible = true;
                lblSectionsResults.Text = "تمت الحذف بنجاح";
            }
            else
            {
                lblSectionsResults.ForeColor = Color.Red;
                lblSectionsResults.Visible = true;
                lblSectionsResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void sectionSelected(object sender, EventArgs e)
        {
            DataTable dt = DA.Content.GetSections(Convert.ToInt32(drpSectionsEdit.SelectedValue));
            txtSectionTitleAREdit.Text = dt.Rows[0]["SectionTitleAR"].ToString();
            txtSectionTitleENEdit.Text = dt.Rows[0]["SectionTitleEN"].ToString();
        }
        protected void SubSectionSelected(object sender, EventArgs e)
        {
            DataTable dt = DA.Content.GetSubSections(Convert.ToInt32(DrpEditSubSections.SelectedValue));
            txtSubSectionTitleAR.Text = dt.Rows[0]["SubSectionTitleAR"].ToString();
            txtSubSectionTitleEN.Text = dt.Rows[0]["SubSectionTitleEN"].ToString();
            DrpSortOrder.SelectedValue = dt.Rows[0]["SortOrder"].ToString();
        }
        protected void btnSaveNewLevel_Click(object sender, EventArgs e)
        {
            if (DA.Content.InsertLevel(txtLevelTitleARAdd.Text.Trim(), txtLevelTitleENAdd.Text.Trim()))
            {
                lblLevelsResults.ForeColor = Color.Green;
                lblLevelsResults.Visible = true;
                lblLevelsResults.Text = "تمت الإضافة بنجاح";
            }
            else
            {
                lblLevelsResults.ForeColor = Color.Red;
                lblLevelsResults.Visible = true;
                lblLevelsResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void btnEditLevel_Click(object sender, EventArgs e)
        {
            if (DA.Content.UpdateLevel(Convert.ToInt32(drpLevelsEdit.SelectedValue), txtLevelTitleAREdit.Text.Trim(), txtLevelTitleENEdit.Text.Trim()))
            {
                lblLevelsResults.ForeColor = Color.Green;
                lblLevelsResults.Visible = true;
                lblLevelsResults.Text = "تمت التعديل بنجاح";
            }
            else
            {
                lblLevelsResults.ForeColor = Color.Red;
                lblLevelsResults.Visible = true;
                lblLevelsResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void btnDeleteLevel_Click(object sender, EventArgs e)
        {
            if (DA.Content.DeleteLevel(Convert.ToInt32(drpLevelsEdit.SelectedValue)))
            {
                lblLevelsResults.ForeColor = Color.Green;
                lblLevelsResults.Visible = true;
                lblLevelsResults.Text = "تمت الحذف بنجاح";
            }
            else
            {
                lblLevelsResults.ForeColor = Color.Red;
                lblLevelsResults.Visible = true;
                lblLevelsResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void LevelSelected(object sender, EventArgs e)
        {
            DataTable dt = DA.Content.GetLevels(Convert.ToInt32(drpLevelsEdit.SelectedValue));
            txtLevelTitleAREdit.Text = dt.Rows[0]["LevelTitleAR"].ToString();
            txtLevelTitleENEdit.Text = dt.Rows[0]["LevelTitleEN"].ToString();
        }
        protected void btnSaveNewCategory_Click(object sender, EventArgs e)
        {
            if (DA.Content.InsertCategory(txtCategoryTitleARAdd.Text.Trim(), txtCategoryTitleENAdd.Text.Trim()))
            {
                lblCategoriesResults.ForeColor = Color.Green;
                lblCategoriesResults.Visible = true;
                lblCategoriesResults.Text = "تمت الإضافة بنجاح";
            }
            else
            {
                lblCategoriesResults.ForeColor = Color.Red;
                lblCategoriesResults.Visible = true;
                lblCategoriesResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (DA.Content.UpdateCategory(Convert.ToInt32(drpCategoriesEdit.SelectedValue), txtCategoryTitleAREdit.Text.Trim(), txtCategoryTitleENEdit.Text.Trim()))
            {
                lblCategoriesResults.ForeColor = Color.Green;
                lblCategoriesResults.Visible = true;
                lblCategoriesResults.Text = "تمت التعديل بنجاح";
            }
            else
            {
                lblCategoriesResults.ForeColor = Color.Red;
                lblCategoriesResults.Visible = true;
                lblCategoriesResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (DA.Content.DeleteCategory(Convert.ToInt32(drpCategoriesDelete.SelectedValue)))
            {
                lblCategoriesResults.ForeColor = Color.Green;
                lblCategoriesResults.Visible = true;
                lblCategoriesResults.Text = "تمت الحذف بنجاح";
            }
            else
            {
                lblCategoriesResults.ForeColor = Color.Red;
                lblCategoriesResults.Visible = true;
            }
        }
        protected void Categorieselected(object sender, EventArgs e)
        {
            DataTable dt = DA.Content.GetCategories(Convert.ToInt32(drpCategoriesEdit.SelectedValue));
            txtCategoryTitleAREdit.Text = dt.Rows[0]["CategoryTitleAR"].ToString();
            txtCategoryTitleENEdit.Text = dt.Rows[0]["CategoryTitleEN"].ToString();
        }
        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            if (editCoverFileUploader.HasFile)
            {
                coverFileUploader.SaveAs(Server.MapPath(coverImagePath));
            }
            if (DA.Content.UpdateContent(txtEditContentTitleAR.Text.Trim(), txtEditContentTitleEN.Text.Trim(),
                Convert.ToInt32(drpEditSections.SelectedItem.Value), Convert.ToInt32(drpEditLevels.SelectedItem.Value),
                Convert.ToInt32(drpEditCategories.SelectedItem.Value), Convert.ToInt32(drpEditSubCategories.SelectedItem.Value),
                Convert.ToInt32(drpEditParts.SelectedItem.Value), txtEditDescription.Text, Convert.ToInt32(drpContent.SelectedItem.Value), 
                Convert.ToInt32(DrpSubSectionsEdit.SelectedItem.Value)))
            {
                lblEditResult.Visible = true;
                lblEditResult.Text = "تم التعديل بنجاح";
            }
            else
            {
                lblEditResult.Visible = true;
                lblEditResult.Text = "خطأ";
            }
        }
        protected void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (DA.Content.DeleteContent(Convert.ToInt32(drpContent.SelectedItem.Value)))
            {
                lblEditResult.Visible = true;
                lblEditResult.Text = "تم الحذف بنجاح";
            }
            else
            {
                lblEditResult.Visible = true;
                lblEditResult.Text = "خطأ";
            }
        }
        protected void drpContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtContent = DA.Content.GetContent(Convert.ToInt32(drpContent.SelectedItem.Value));
            if (dtContent.Rows.Count > 0)
            {
                lblContent.Text = "ID: " + dtContent.Rows[0]["ContentID"].ToString();
                txtEditContentTitleAR.Text = dtContent.Rows[0]["ContentTitleAR"].ToString();
                txtEditContentTitleEN.Text = dtContent.Rows[0]["ContentTitleEN"].ToString();
                txtEditDescription.Text = dtContent.Rows[0]["Description"].ToString();
                coverImagePath = dtContent.Rows[0]["CoverPic"].ToString();
            }
        }
        public void GetSections(DropDownList drp, int SectionID = -1, string FirstOption = "")
        {
            drp.Items.Clear();
            DataTable dtSections = DA.Content.GetSections(SectionID);
            if (dtSections.Rows.Count > 0)
            {
                drp.DataSource = dtSections;
                drp.DataTextField = "SectionTitleAR";
                drp.DataValueField = "SectionID";
                drp.DataBind();

                drp.Items.Insert(0, new ListItem(FirstOption, "-1"));
            }
        }
        public void GetSubSections(DropDownList drp, int SubSectionID = -1, string FirstOption = "")
        {
            drp.Items.Clear();
            DataTable dtSubSections = DA.Content.GetSubSections(SubSectionID);
            if (dtSubSections.Rows.Count > 0)
            {
                drp.DataSource = dtSubSections;
                drp.DataTextField = "SubSectionTitleAR";
                drp.DataValueField = "SubSectionID";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem(FirstOption, "-1"));
            }
        }
        public void GetLevels(DropDownList drp, int LevelID = -1, string FirstOption = "")
        {
            drp.Items.Clear();
            DataTable dtLevels = DA.Content.GetLevels(LevelID);
            if (dtLevels.Rows.Count > 0)
            {
                drp.DataSource = dtLevels;
                drp.DataTextField = "LevelTitleAR";
                drp.DataValueField = "LevelID";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem(FirstOption, "-1"));
            }
        }
        public void GetCategories(DropDownList drp, int CategoryID = -1, string FirstOption = "")
        {
            drp.Items.Clear();
            DataTable dtCategories = DA.Content.GetCategories(CategoryID);
            if (dtCategories.Rows.Count > 0)
            {
                drp.DataSource = dtCategories;
                drp.DataTextField = "CategoryTitleAR";
                drp.DataValueField = "CategoryID";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem(FirstOption, "-1"));
            }
        }
        public void GetSubCategories(DropDownList drp, int SubCategoryID = -1, string FirstOption = "")
        {
            drp.Items.Clear();
            DataTable dtSubCategories = DA.Content.GetSubCategories(SubCategoryID);
            if (dtSubCategories.Rows.Count > 0)
            {
                drp.DataSource = dtSubCategories;
                drp.DataTextField = "SubCategoryTitleAR";
                drp.DataValueField = "SubCategoryID";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem(FirstOption, "-1"));
            }
        }
        public void GetParts(DropDownList drp, int PartID = -1, string FirstOption = "")
        {
            drp.Items.Clear();
            DataTable dtParts = DA.Content.GetParts(PartID);
            if (dtParts.Rows.Count > 0)
            {
                drp.DataSource = dtParts;
                drp.DataTextField = "PartTitleAR";
                drp.DataValueField = "PartID";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem(FirstOption, "-1"));
            }
        }
        public void GetContents()
        {
            drpContent.Items.Clear();
            int SectionID = (Convert.ToInt32(drpEditSections.SelectedItem.Value) == 0) ? -1 : Convert.ToInt32(drpEditSections.SelectedItem.Value);
            int SubSectionID = (Convert.ToInt32(DrpSubSectionsEdit.SelectedItem.Value) == 0) ? -1 : Convert.ToInt32(DrpSubSectionsEdit.SelectedItem.Value);
            int LevelID = (Convert.ToInt32(drpEditLevels.SelectedItem.Value) == 0) ? -1 : Convert.ToInt32(drpEditLevels.SelectedItem.Value);
            int CategoryID = (Convert.ToInt32(drpEditCategories.SelectedItem.Value) == 0) ? -1 : Convert.ToInt32(drpEditCategories.SelectedItem.Value);
            int SubCategoryID = (Convert.ToInt32(drpEditSubCategories.SelectedItem.Value) == 0) ? -1 : Convert.ToInt32(drpEditSubCategories.SelectedItem.Value);
            int PartID = (Convert.ToInt32(drpEditParts.SelectedItem.Value) == 0) ? -1 : Convert.ToInt32(drpEditParts.SelectedItem.Value);
            DataTable dtContentList = DA.Content.GetContents(SectionID, LevelID, CategoryID, SubCategoryID, PartID, SubSectionID);
            if (dtContentList.Rows.Count > 0)
            {
                drpContent.Items.Clear();
                drpContent.DataSource = dtContentList;
                drpContent.DataTextField = "ContentTitleAR";
                drpContent.DataValueField = "ContentID";
                drpContent.DataBind();
                SortListControl(drpContent, true);
                drpContent.Items.Insert(0, new ListItem("اختر", "0"));
                lblContent.Text = "Total: " + dtContentList.Rows.Count;
            }
        }
        public static void SortListControl(ListControl control, bool isAscending)
        {
            List<ListItem> collection;

            if (isAscending)
                collection = control.Items.Cast<ListItem>()
                    .Select(x => x)
                    .OrderBy(x => x.Text)
                    .ToList();
            else
                collection = control.Items.Cast<ListItem>()
                    .Select(x => x)
                    .OrderByDescending(x => x.Text)
                    .ToList();

            control.Items.Clear();

            foreach (ListItem item in collection)
                control.Items.Add(item);
        }
        protected void btnSaveNewSubSection_Click(object sender, EventArgs e)
        {
            if (DA.Content.InsertSubSection(txtSubSectionAR.Text.Trim(), txtSubSectionEN.Text.Trim()))
            {
                lblManageSubSections.ForeColor = Color.Green;
                lblManageSubSections.Visible = true;
                lblManageSubSections.Text = "تمت الإضافة بنجاح";
            }
            else
            {
                lblManageSubSections.ForeColor = Color.Red;
                lblManageSubSections.Visible = true;
                lblManageSubSections.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void BtnEditSubSection_Click(object sender, EventArgs e)
        {
            if (DA.Content.UpdateSubSection(Convert.ToInt32(DrpEditSubSections.SelectedValue), txtSubSectionTitleAR.Text.Trim(),
                txtSubSectionTitleEN.Text.Trim(), Convert.ToInt32(DrpSortOrder.SelectedValue)))
            {
                lblManageSubSections.ForeColor = Color.Green;
                lblManageSubSections.Visible = true;
                lblManageSubSections.Text = "تمت التعديل بنجاح";
            }
            else
            {
                lblManageSubSections.ForeColor = Color.Red;
                lblManageSubSections.Visible = true;
                lblManageSubSections.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void BtnGetContent_Click(object sender, EventArgs e)
        {
            GetContents();
        }
    }
}