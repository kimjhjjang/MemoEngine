using System;
using System.Configuration;
using System.IO;

namespace MemoEngine.Answers
{
    public partial class BoardDown : System.Web.UI.Page
    {
        private readonly AnswerRepository repository;

        public BoardDown()
        {
            repository = new AnswerRepository(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        public string FileUploadPath { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            // 다운로드 폴더 지정 : 실제 사용시 반드시 변경
            FileUploadPath = Server.MapPath("/BoardFiles/Answers");

            // 넘겨저 온 번호에 해당하는 파일명 가져오기(보안떄문에 파일명 숨김)
            string fileName = repository.GetFileNameById(Convert.ToInt32(Request["Id"]));

            if( fileName != null)
            {
                if (!String.IsNullOrEmpty(fileName))
                {
                    //다운로드시 카운트 증가 매서드 호출

                    repository.UpdateDownCountById(int.Parse(Request["Id"]));

                    //[i] 강제 다운로드 창 띄우기 주요 로직
                    Response.Clear();
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", "attachment; filename="
                        + Server.UrlPathEncode((fileName.Length > 50) ? fileName.Substring(fileName.Length - 50, 50) : fileName));
                    Response.WriteFile(Path.Combine(FileUploadPath, fileName));
                }
            }
            else
            {
                Response.Clear();
                Response.End();
            }

        }
    }
}