using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int MaterialID;
            if (!Page.IsPostBack)
            {
                MaterialID = Convert.ToInt32(Request.QueryString.Get("mid"));
                if (MaterialID != 0)
                {
                    DataTable dtMaterial;
                    if (Session["IsGame"] == "Yes")
                    {
                        dtMaterial = DA.Content.GetGame(MaterialID);
                        if (dtMaterial.Rows.Count > 0)
                        {
                            lblMaterialTitle.Text = dtMaterial.Rows[0]["MaterialTitle"].ToString();
                            aClassName.InnerText = dtMaterial.Rows[0]["ClassNameAR"].ToString();
                            aClassName.HRef = "WorkSheets.aspx?CID=" + dtMaterial.Rows[0]["ClassID"].ToString();
                            ImgSubject.ImageUrl = dtMaterial.Rows[0]["SubjectPic"].ToString();
                            aSubjectName.HRef = "WorkSheetsMaterial.aspx?sid=" + dtMaterial.Rows[0]["ClassSubjectID"].ToString();
                            aSubjectName.InnerText = dtMaterial.Rows[0]["SubjectNameAR"].ToString();
                            classDiv.Style.Add("background", dtMaterial.Rows[0]["DivBg"].ToString());
                        }
                    }
                    else
                    {
                        dtMaterial = DA.Content.GetMaterial(MaterialID);
                        if (dtMaterial.Rows.Count > 0)
                        {
                            lblMaterialTitle.Text = dtMaterial.Rows[0]["MaterialTitle"].ToString();
                            aClassName.InnerText = dtMaterial.Rows[0]["ClassNameAR"].ToString();
                            aClassName.HRef = "WorkSheets.aspx?CID=" + dtMaterial.Rows[0]["ClassID"].ToString();
                            ImgSubject.ImageUrl = dtMaterial.Rows[0]["SubjectPic"].ToString();
                            aSubjectName.HRef = "WorkSheetsMaterial.aspx?sid=" + dtMaterial.Rows[0]["ClassSubjectID"].ToString();
                            aSubjectName.InnerText = dtMaterial.Rows[0]["SubjectNameAR"].ToString();
                            classDiv.Style.Add("background", dtMaterial.Rows[0]["DivBg"].ToString());
                        }
                    }
                }
            }
        }
        public string GetFileName()
        {
            int MaterialID = Convert.ToInt32(Request.QueryString.Get("mid"));
            if (MaterialID == 0)
            {
                Response.Redirect("WorkSheets.aspx");
            }
            if (Session["IsGame"] == "Yes")
            {
                DataTable dtMaterial = DA.Content.GetGame(MaterialID);
                lblMaterialTitle.Text = dtMaterial.Rows[0]["MaterialTitle"].ToString();
                return dtMaterial.Rows[0]["MaterialFile"].ToString();
            }
            else
            {
                DataTable dtMaterial = DA.Content.GetMaterial(MaterialID);
                lblMaterialTitle.Text = dtMaterial.Rows[0]["MaterialTitle"].ToString();
                return dtMaterial.Rows[0]["MaterialFile"].ToString();
            }
        }
    }
}