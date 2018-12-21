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
namespace DarAlSadeeq.admin
{
    public partial class ManageContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btn_save_Click(object sender, EventArgs e)
        {
            string contentPath = "~/content/" + DrpDwnLevels.SelectedValue + "/" + DrpDwnCategories.SelectedValue +
                "/" + drpParts.SelectedValue + "/" + txtContentTitleAR.Text + "/" + drpContentType.SelectedValue;
            if (!Directory.Exists(Server.MapPath(contentPath)))
                Directory.CreateDirectory(Server.MapPath(contentPath));
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
            if (DA.Content.InsertContent(txtContentTitleAR.Text.Trim(), txtContentTitleEN.Text.Trim(), drpContentType.SelectedItem.Text,
                contentPath, Convert.ToInt32(DrpDwnLevels.SelectedValue), Convert.ToInt32(DrpDwnCategories.SelectedValue),
                Convert.ToInt32(drpParts.SelectedValue), Convert.ToInt32(drpSections.SelectedValue), txtDescription.Text,
                contentPath + "/cover" + Path.GetExtension(coverFileUploader.FileName),Convert.ToInt32(drpSubCategories.SelectedValue)))
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
            if (DA.Content.UpdateSection(Convert.ToInt32(drpSectionsEdit.SelectedValue),txtSectionTitleAREdit.Text.Trim(), txtSectionTitleENEdit.Text.Trim()))
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
            if (DA.Content.DeleteCategory(Convert.ToInt32(drpCategoriesEdit.SelectedValue)))
            {
                lblCategoriesResults.ForeColor = Color.Green;
                lblCategoriesResults.Visible = true;
                lblCategoriesResults.Text = "تمت الحذف بنجاح";
            }
            else
            {
                lblCategoriesResults.ForeColor = Color.Red;
                lblCategoriesResults.Visible = true;
                lblCategoriesResults.Text = "خطأ في عملية الإدخال";
            }
        }
        protected void Categorieselected(object sender, EventArgs e)
        {
            DataTable dt = DA.Content.GetCategories(Convert.ToInt32(drpCategoriesEdit.SelectedValue));
            txtCategoryTitleAREdit.Text = dt.Rows[0]["CategoryTitleAR"].ToString();
            txtCategoryTitleENEdit.Text = dt.Rows[0]["CategoryTitleEN"].ToString();
        }
    }
}