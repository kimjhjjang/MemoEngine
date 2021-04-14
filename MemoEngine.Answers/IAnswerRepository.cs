using System;
using System.Collections.Generic;
using System.Text;

namespace MemoEngine.Answers
{
    public interface IAnswerRepository : IBreadShop<Answer>
    {
        int delete(int id, string password);
        
        List<Answer> GetAnswers(int pagenumber, int pagesize = 10);
        /// <summary>
        ///전체 레코드 수 반환 : Answers 테이블의 모든 레코드 수
        ///</summary>
        int GetCountAll();

        /// <summary>
        ///검색 결과에 따른 총 레코드 카운트
        ///</summary>
        int GetCountBySearch(String searchField, String searchQuery);

        /// <summary>
        /// GetAll(); FindAll() 형태로 주로 사용 또는 GetNotes(), GetComments(), GetAnswers() 형태로 많이 사용
        ///</summary>
        List<Answer> GetAll(int pageNumber, int pageSize = 10);

        List<Answer> GetSearchAll( String searchField, String searchQuery, int pageNumber, int pageSize = 10 );

        List<Answer> GetSummaryByCategory(String category);

        String GetFileNameById(int id);

        List<Answer> GetPhotos();

        Answer GetById(int id);

        List<Answer> GetRecentPosts(int number = 5);

        void Pinned(int id);

        void ReplyModel(Answer model);

        int SaveOrUpdate(Answer n, BoardWriteFormType formType);

        int UpdateDownCount(string filename);

        int UpdateDownCountById(int id);

        int UpdateModel(Answer model);

        Answer WriteModel(Answer model);
    }
}
