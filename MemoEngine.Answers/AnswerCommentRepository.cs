﻿using System;
using System.Collections.Generic;

namespace MemoEngine.Answers
{
    public class AnswerCommentRepository : IAnswerCommentRepository
    {
        public AnswerComment Add(AnswerComment model)
        {
            throw new NotImplementedException();
        }

        public void AddComment(AnswerComment model)
        {
            throw new NotImplementedException();
        }

        public AnswerComment Browse(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteComment(int articleId, int id, string password)
        {
            throw new NotImplementedException();
        }

        public bool Edit(AnswerComment model)
        {
            throw new NotImplementedException();
        }

        public List<AnswerComment> GetComment(int articleId)
        {
            throw new NotImplementedException();
        }

        public int GetCountBy(int articleId, int id, string password)
        {
            throw new NotImplementedException();
        }

        public List<AnswerComment> GetRecentComment()
        {
            throw new NotImplementedException();
        }

        public int Has()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AnswerComment> Ordering(OrderOption orderOption)
        {
            throw new NotImplementedException();
        }

        public List<AnswerComment> Paging(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<AnswerComment> Read()
        {
            throw new NotImplementedException();
        }

        public List<AnswerComment> Search(string query)
        {
            throw new NotImplementedException();
        }
    }
}
