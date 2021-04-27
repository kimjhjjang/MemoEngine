using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngine.Answers.Controls
{
    public partial class BoardCommentControl : System.Web.UI.UserControl
    {
        private readonly IAnswerCommentRepository repository;

        public BoardCommentControl()
        {
             repository = new AnswerCommentRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            throw new NotImplementedException();
        }

        protected void btnWriteComment_Click(object sender, EventArgs e)
        {

        }
    }
}