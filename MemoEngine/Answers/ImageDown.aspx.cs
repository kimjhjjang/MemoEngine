using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngine.Answers
{
    public partial class ImageDown : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // 넘겨온 파일명 체크
            if (String.IsNullOrEmpty(Request.QueryString["FileName"]))
            {
                Response.Clear();
                Response.End();
            }
            // 넘어온 파일이 이미지인지 체크 
            string fileName = Request.Params["FileName"].ToString();
            string ext = Path.GetExtension(fileName); // 확장자만 추출
            string contentType = "";
            if (ext == ".gif" || ext == ".jpg" || ext == ".jpeg" || ext == ".png")
            {
                switch (ext)
                {
                    case ".gif": contentType = "image/gif"; break;
                    case ".jpg": contentType = "image/jpg"; break;
                    case ".jpeg": contentType = "image/jpeg"; break;
                    case ".png": contentType = "image/png"; break;
                }
            }
            else
            {
                Response.Write("<script language='javascript'>" + "alert('이미지 파일이 아닙니다.')</script>");
                Response.End();
            }
            // 업로드된 이미지 다운로드
            string file = Server.MapPath("/BoardFiles/Answers/") + fileName;

            // 강제 다운로드 로직 적용
            Response.Clear();
            Response.ContentType = contentType;
            Response.WriteFile(file);
            Response.End();
        }
    }
}