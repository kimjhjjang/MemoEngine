using System;
using System.Collections.Generic;
using System.Text;

namespace MemoEngine.Answers
{
    public interface IAnswerRepository : IBreadShop<Answer>
    {
        int delete(int id, string password);
        
        List<Answer> GetAnswers(int pagenumber, int pagesize = 10);

        int GetCountAll();

        int GetCountBySearch(String searchField, String searchQuery);

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
