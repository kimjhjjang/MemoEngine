using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MemoEngine.Answers
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly SqlConnection db;

        public AnswerRepository(string connectionString)
        {
            db = new SqlConnection(connectionString);
        }

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
        /// <summary>
        /// GetAll(); FindAll() 형태로 주로 사용 또는 GetNotes(), GetComments(), GetAnswers() 형태로 많이 사용
        ///</summary>
        public List<Answer> GetAll(int pageNumber, int pageSize = 10)
        {
            try 
            {
                var parameters = new DynamicParameters(new { PageNumber = pageNumber, PageSize = pageSize });
                return db.Query<Answer>("AnswersList",
                                        parameters, commandType : 
                                        CommandType.StoredProcedure).ToList();
            }
            catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public List<Answer> GetAnswers(int pagenumber, int pagesize = 10)
        {
            throw new NotImplementedException();
        }

        public Answer GetById(int id)
        {
            throw new NotImplementedException();
        }

        //전체 레코드수 반환 : Answers 테이블의 모든 레코드 수
        public int GetCountAll()
        {
            try
            {
                return db.Query<int>("Select Count(*) From Answers").SingleOrDefault();
            }catch(System.Exception)
            {
                return -1;
            }
        }

        //검색 결과에 따른 총 레코드 카운트
        public int GetCountBySearch(string searchField, string searchQuery)
        {
            try
            {
                return db.Query<int>("AnswersSearchCount", new
                {
                    SearchField = searchField,
                    SearchQuery = searchQuery
                },
                    commandType: CommandType.StoredProcedure)
                    .SingleOrDefault();
            }
            catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
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
            var parameters = new DynamicParameters(
                new { SearchField = searchField, SearchQuery = searchQuery, PageNumber = pageNumber, PageSize = pageSize });
            return db.Query<Answer>("AnswersSearchList", parameters, commandType: CommandType.StoredProcedure).ToList();
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
