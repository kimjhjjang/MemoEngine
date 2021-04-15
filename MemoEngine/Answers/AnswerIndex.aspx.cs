using System;
using System.Configuration;
using System.Web;

namespace MemoEngine.Answers
{
    public partial class AnswerIndex : System.Web.UI.Page
    {


        #region 아티클 검색 관련 속성들 
        /// <summary>
        /// 현재 보기 모드가 기본(Normal) 모드(false)인지 검색(Search) 모드(true)인지 확인
        /// </summary>
        public bool SearchMode { get; set; } = false;
        /// <summary>
        /// 검색 필드: Name(UserId), Title, Content
        /// </summary>
        public string SearchField { get; set; } = "Title";
        /// <summary>
        /// 검색 내용
        /// </summary>
        public string SearchQuery { get; set; } = "";
        #endregion

        public int PageNumber = 1; // 현재 보여줄 페이지 번호
        public int PageSize { get; set; } = 10; // 몇 개의 항목을 표시 할지
        public int RecoredCount = 0; // 총 레코드 개수(글 번호 순서 정렬용)
        
        private readonly string connectionString;
        private readonly IAnswerRepository _repository;

        public AnswerIndex()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            _repository = new AnswerRepository(connectionString);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            #region 검색 모드 결정 : 검색 모드이면 SearchMode 속성이 true
            // 검색 모드 결정  : 검색 모드이면 SearchMode 속성이 true
            if (!String.IsNullOrEmpty(HttpContext.Current.Request["SearchQuery"])
                &&
                !String.IsNullOrEmpty(HttpContext.Current.Request["SearchField"]))
            {
                SearchMode = true;
                SearchField = SqlUtility.EncodeSqlString(HttpContext.Current.Request["SearchQuery"]); // 검색할 필드
                SearchQuery = SqlUtility.EncodeSqlString(HttpContext.Current.Request["SearchField"]); // 검색할 내용
            }

            #endregion

            #region 쿠키로 페이지 번호 유지
            String cookieName = Request["BoardName"]; // 단일형 = ArticleIndex 또는 멀티형 게시판 = 게시판 별칭
            if(String.IsNullOrEmpty(cookieName))
            {
                cookieName = "ArticleIndex";
            }
            if(!String.IsNullOrEmpty(Request["Page"]))
            {
                PageNumber = Convert.ToInt32(Request["Page"]);
                Response.Cookies[cookieName]["Page"] = PageNumber.ToString();
            }
            else
            {
                // 쿠키를 사용한 리스트 페이지 번호 유지 적용 : 각 게시판별 페이지 번호가 따로 저장됨
                if(Request.Cookies[cookieName] != null && Request.Cookies[cookieName]["Page"] != null)
                {
                    if(!String.IsNullOrEmpty(Request.Cookies[cookieName]["Page"]))
                    {
                        PageNumber = Convert.ToInt32(Request.Cookies[cookieName]["Page"]);
                    }
                }
            }
            #endregion

            #region 레코드 카운트 출력
            if (!SearchMode)
            {
                RecoredCount = _repository.GetCountAll();
            }
            else
            {
                RecoredCount = _repository.GetCountBySearch(SearchField, SearchQuery);
            }
            lblTotalRecord.Text = RecoredCount.ToString(); //레코드수 출력
            #endregion

            #region 페이징 처리
            this.AdvancedPagingSingleWithBootstrap.PageIndex = PageNumber - 1;
            this.AdvancedPagingSingleWithBootstrap.RecordCount = RecoredCount;

            #endregion

            //페이지 처음 로드시 게시판 데이터 출력
            if(!Page.IsPostBack)
            {
                DisplayData();
            }

        }
        private void DisplayData()
        {
            if (!SearchMode)
            {

            }
            else
            {
                ctlBoardList.DataSource = _repository.GetSearchAll(SearchField, SearchQuery, PageNumber, PageSize);
            }
            ctlBoardList.DataBind();
        }
    }
}