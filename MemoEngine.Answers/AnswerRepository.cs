﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MemoEngine.Answers
{
    public class AnswerRepository : IAnswerRepository
    {
        public Answer Add(Answer model)
        {
            throw new NotImplementedException();
        }

        public Answer Browse(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int delete(int id, string password)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Answer model)
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetAnswers(int pagenumber, int pagesize = 10)
        {
            throw new NotImplementedException();
        }

        public Answer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetCountAll()
        {
            throw new NotImplementedException();
        }

        public int GetCountBySearch(string searchField, string searchQuery)
        {
            throw new NotImplementedException();
        }

        public string GetFileNameById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetPhotos()
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetRecentPosts(int number = 5)
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetSearchAll(string searchField, string searchQuery, int pageNumber, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public List<Answer> GetSummaryByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public int Has()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Answer> Ordering(OrderOption orderOption)
        {
            throw new NotImplementedException();
        }

        public List<Answer> Paging(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Pinned(int id)
        {
            throw new NotImplementedException();
        }

        public List<Answer> Read()
        {
            throw new NotImplementedException();
        }

        public void ReplyModel(Answer model)
        {
            throw new NotImplementedException();
        }

        public int SaveOrUpdate(Answer n, BoardWriteFormType formType)
        {
            throw new NotImplementedException();
        }

        public List<Answer> Search(string query)
        {
            throw new NotImplementedException();
        }

        public int UpdateDownCount(string filename)
        {
            throw new NotImplementedException();
        }

        public int UpdateDownCountById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateModel(Answer model)
        {
            throw new NotImplementedException();
        }

        public Answer WriteModel(Answer model)
        {
            throw new NotImplementedException();
        }
    }
}
