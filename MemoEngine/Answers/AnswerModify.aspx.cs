using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MemoEngine.Answers
{
    public partial class AnswerEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctlBoardEditorFormControl.FormType = BoardWriteFormType.Modify;
            ctlBoardEditorFormControl.Message = "글수정 - 다음 필드들을 채워주세요";
        }
    }
}