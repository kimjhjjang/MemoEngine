using System;
using System.Collections.Generic;
using System.Text;

namespace MemoEngine.Answers
{
    public interface IAnswerCommentRepository : IBreadShop<AnswerComment>
    {
        void AddComment(AnswerComment model);

        int DeleteComment(int articleId, int id, String password);

        List<AnswerComment> GetComments(int articleId);

        int GetCountBy(int articleId, int id, String password);

        List<AnswerComment> GetRecentComment();
    }
}
