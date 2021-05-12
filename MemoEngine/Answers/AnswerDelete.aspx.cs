using System;
using System.Configuration;

namespace MemoEngine.Answers
{
    public partial class AnswerDelete : System.Web.UI.Page
    {
        private readonly AnswerRepository repository;

        public AnswerDelete()
        {
            repository = new AnswerRepository(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        public int Id { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(Request.QueryString["Id"]);

            lblId.Text = Id.ToString();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (repository.Delete(Convert.ToInt32(Id), txtPassword.Text) >0)
            {
                Response.Redirect("AnswerIndex.aspx");
                
            }
            else
            {
                lblMessage.Text = "삭제되지 않았습니다. 비밀번호를 확인하세요.";
            }
        }
    }
}