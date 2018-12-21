using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class WorkSheetsMaterial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int subjectID;
            if (!Page.IsPostBack)
            {
                subjectID = Convert.ToInt32(Request.QueryString.Get("sid"));
                int[] IDs = { 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 107 };
                DataTable dtMaterials;
                foreach (int id in IDs)
                {
                    if (subjectID == id)
                    {
                        dtMaterials = DA.Content.ListGames(subjectID);
                        Session["IsGame"] = "Yes";
                        if (dtMaterials.Rows.Count > 0)
                        {
                            aClassName.InnerText = dtMaterials.Rows[0]["ClassNameAr"].ToString();
                            aClassName.HRef = "WorkSheets.aspx?CID=" + dtMaterials.Rows[0]["ClassID"].ToString();
                            ImgSubject.ImageUrl = dtMaterials.Rows[0]["SubjectPic"].ToString();
                            aSubjectName.InnerText = dtMaterials.Rows[0]["SubjectNameAr"].ToString();
                            classDiv.Style.Add("background", dtMaterials.Rows[0]["DivBg"].ToString());
                            Repeater1.DataSource = dtMaterials;
                            Repeater1.DataBind();
                        }
                    }
                    else
                    {
                        dtMaterials = DA.Content.ViewLearnMaterails(subjectID);
                        if (dtMaterials.Rows.Count > 0)
                        {
                            aClassName.InnerText = dtMaterials.Rows[0]["ClassNameAr"].ToString();
                            aClassName.HRef = "WorkSheets.aspx?CID=" + dtMaterials.Rows[0]["ClassID"].ToString();
                            ImgSubject.ImageUrl = dtMaterials.Rows[0]["SubjectPic"].ToString();
                            aSubjectName.InnerText = dtMaterials.Rows[0]["SubjectNameAr"].ToString();
                            classDiv.Style.Add("background", dtMaterials.Rows[0]["DivBg"].ToString());
                            Repeater1.DataSource = dtMaterials;
                            Repeater1.DataBind();
                        }
                    }
                }

            }
        }
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = e.Item.DataItem as DataRowView;
                HtmlAnchor b = e.Item.FindControl("link1") as HtmlAnchor;
                if (drv.Row["FileType"].ToString().ToUpper() == "PDF")
                {
                    b.HRef = "../Materials/" + drv.Row["MaterialFile"].ToString();
                    b.Target = "_blank";
                }
                else
                {
                    b.HRef = "view.aspx?mid=" + drv.Row["MaterialID"].ToString();
                }
            }
        }
    }
}