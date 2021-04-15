using System;
using System.Configuration;

namespace MemoEngine.Answers.Controls
{
    public partial class BoardEditorFormControl : System.Web.UI.UserControl
    {
            #region 공통 속성
        /// <summary>
        /// 글쓰기 폼 형식 : Write , Modify, Reply
        /// </summary>
        public BoardWriteFormType FormType { get; set; }

        /// <summary>
        /// 상단 메세지 출력 영역 : create(Write), Edit(Modify), Reply 에서 넘어온 문자열 값
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 파일 업로드 폴더 : Web.config 의 File_upload_folder
        /// </summary>
        public string FileUploadPath { get; set; }
        #endregion

        private readonly string connectionString;
        private readonly IAnswerRepository _repository;
        public BoardEditorFormControl()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _repository = new AnswerRepository(connectionString);
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}