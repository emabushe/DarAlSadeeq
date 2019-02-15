using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class ManageVideos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_save_Click(object sender, EventArgs e)
        {
            string coverImage = Server.MapPath("~/images/") + coverFileUploader.FileName;
            coverFileUploader.SaveAs(coverImage);
            if (DA.Content.InsertVideo(txtContentTitleAR.Text, coverImage, txtYoutube.Text))
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
        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DA.Content.DeleteVideo(Convert.ToInt32(drpVideos.SelectedItem.Value)))
            {
                lblDeleteResult.ForeColor = Color.Green;
                lblDeleteResult.Visible = true;
            }
            else
            {
                lblDeleteResult.ForeColor = Color.Red;
                lblDeleteResult.Visible = true;
                lblDeleteResult.Text = "خطأ في عملية الإدخال";
            }
        }
    }
}