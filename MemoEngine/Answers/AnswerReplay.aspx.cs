using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngine.Answers
{
    public partial class AnswerReplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlBoardEditorFormControl.FormType = BoardWriteFormType.Reply;
            ctlBoardEditorFormControl.Message = "글 답변 - 다음 필드들을 채워주세요";
        }
    }
}