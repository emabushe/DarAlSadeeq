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
            divPDFContent.Visible = false;
            divFlashContent.Visible = false;
            if (!Page.IsPostBack)
            {
                MaterialID = Convert.ToInt32(Request.QueryString.Get("mid"));
                if (MaterialID != 0)
                {
                    DataTable dtMaterial= DA.Content.GetMaterial(MaterialID);
                    if(dtMaterial.Rows.Count>0)
                    {
                        lblMaterialTitle.Text = dtMaterial.Rows[0]["MaterialTitle"].ToString();
                        aClassName.InnerText = dtMaterial.Rows[0]["ClassNameAR"].ToString();
                        aClassName.HRef = "WorkSheets.aspx?CID=" + dtMaterial.Rows[0]["ClassID"].ToString();
                        ImgSubject.ImageUrl = dtMaterial.Rows[0]["SubjectPic"].ToString();
                        aSubjectName.HRef = "WorkSheetsMaterial.aspx?sid=" + dtMaterial.Rows[0]["ClassSubjectID"].ToString();
                        aSubjectName.InnerText = dtMaterial.Rows[0]["SubjectNameAR"].ToString();
                        classDiv.Style.Add("background", dtMaterial.Rows[0]["DivBg"].ToString());
                        switch (dtMaterial.Rows[0]["FileType"].ToString().ToUpper())
                        {
                            case "PDF":
                                divPDFContent.Visible = true;
                                divFlashContent.Visible = false;
                                pdfViewer.Attributes["src"] = "../../Materials/" + dtMaterial.Rows[0]["MaterialFile"].ToString();
                                pdfURL.HRef = "../../Materials/" + dtMaterial.Rows[0]["MaterialFile"].ToString();
                                break;

                            case "SWF":
                                divPDFContent.Visible = false;
                                divFlashContent.Visible = true;
                                flashViewer.Attributes["src"] = "../../Materials/" + dtMaterial.Rows[0]["MaterialFile"].ToString();
                                break;
                        }
                    }
                    else
                    {
                        lblBody.Visible = true;
                    }
                }
                else
                {
                    lblBody.Visible = true;
                }
            }
        }
    }
}