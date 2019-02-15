using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DarAlSadeeq.ar
{
    public partial class ContentViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int ContentID = Convert.ToInt32(Request.QueryString.Get("content"));
                divPagesContent.Visible = false;
                divPDFContent.Visible = false;
                divHTMLContent.Visible = false;
                divImageContent.Visible = false;
                DataTable dtContent;
                if (ContentID != 0)
                {

                    dtContent = DA.Content.GetContent(ContentID);
                    if (dtContent.Rows.Count > 0)
                    {
                        lblSectionTitle.Text = dtContent.Rows[0]["ContentTitleAR"].ToString();
                        divTitle.Attributes["class"] = "block-main no-margin";
                        string contentPath = dtContent.Rows[0]["ContentPath"].ToString();
                        DirectoryInfo dir = new DirectoryInfo(Server.MapPath(contentPath));
                        switch (dtContent.Rows[0]["ContentType"].ToString())
                        {
                            case "Pages":
                                divPagesContent.Visible = true;
                                DataTable dtPages = new DataTable();
                                dtPages.Clear();
                                dtPages.Columns.Add("PagePath");
                                contentPath = contentPath.Replace("~", "../..");
                                foreach (var file in dir.GetFiles())
                                {
                                    if (file.Name != "cover.png")
                                    {
                                        DataRow row = dtPages.NewRow();
                                        row["PagePath"] = contentPath + "/" + file.Name;
                                        dtPages.Rows.Add(row);
                                    }
                                }
                                rptPages.DataSource = dtPages;
                                rptPages.DataBind();
                                break;
                            case "PDF":
                                divPDFContent.Visible = true;
                                contentPath = contentPath.Replace("~", "../..");
                                foreach (var file in dir.GetFiles("*.pdf"))
                                {
                                    pdfViewer.Attributes["src"] = contentPath + "/" + file.Name;
                                    pdfURL.HRef= contentPath + "/" + file.Name;
                                    break;
                                }
                                break;
                            case "HTML Page":
                                divHTMLContent.Visible = true;
                                contentPath = contentPath.Replace("~", "../..");
                                foreach (var file in dir.GetFiles("*.html"))
                                {
                                    htmlViewer.Attributes["src"] = contentPath + "/" + file.Name;
                                    ebookURL.HRef= contentPath + "/" + file.Name;
                                    break;
                                }
                                break;
                            case "Image":
                                divImageContent.Visible = true;
                                lblTitle.Text= dtContent.Rows[0]["ContentTitleAR"].ToString();
                                imgContent.ImageUrl = dtContent.Rows[0]["CoverPic"].ToString();
                                lblDescription.Text = dtContent.Rows[0]["Description"].ToString();
                                break;
                            case "Youtube":
                                divYoutubeContent.Visible = true;
                                divYoutube.InnerHtml = contentPath;
                                break;
                        }
                    }
                }
            }
        }
    }
}