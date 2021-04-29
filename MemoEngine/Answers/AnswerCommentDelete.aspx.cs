using System;
using System.Configuration;

namespace MemoEngine.Answers
{
    public partial class AnswerCommentDelete : System.Web.UI.Page
    {
        private readonly IAnswerCommentRepository repository;

        public AnswerCommentDelete()
        {
            repository = new AnswerCommentRepository(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        public int ArticleId { get; set; }
        public int Id { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["ArticleId"] != null && Request.QueryString["Id"] != null)
            {
                ArticleId = Convert.ToInt32(Request["ArticleId"]);
                Id = Convert.ToInt32(Request["Id"]);
            }
            else
            {
                Response.End();
            }
        }

        protected void btnCommentDelete_Click(object sender, EventArgs e)
        {
            if (repository.GetCountBy(ArticleId, Id, txtPassword.Text ) > 0)
            {
                repository.DeleteComment(ArticleId, Id, txtPassword.Text);
                Response.Redirect($"AnswerDetails.aspx?Id={ArticleId}");
            }
            else
            {
                lblError.Text = "암호가 틀립니다. 다시 입력해주세요.";
            }
        }
    }
}