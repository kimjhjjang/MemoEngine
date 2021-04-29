using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Linq;

namespace MemoEngine.Answers
{
    public class AnswerCommentRepository : IAnswerCommentRepository
    {
        private readonly SqlConnection db;

        public AnswerCommentRepository(string connectionString)
        {
            db = new SqlConnection(connectionString);
        }

        public AnswerComment Add(AnswerComment model)
        {
            throw new NotImplementedException();
        }

        public void AddComment(AnswerComment model)
        {
            // 쿼리문 댓글 입력 및 게시판 코멘트 수 추가
            string sql = @"
            Insert Into AnswersComments (ArticleId , Name, Opinion, Password )
            Values (@ArticleId , @Name, @Opinion, @Password );

            Update Answers Set CommentCount = CommentCount +1 Where Id = @ArticleId
            ";

            // 파라미터 추가
            var parameters = new DynamicParameters();
            parameters.Add("@ArticleId", value: model.ArticleId, dbType: DbType.Int32);
            parameters.Add("@Name", value: model.Name, dbType: DbType.String);
            parameters.Add("@Opinion", value: model.Opinion, dbType: DbType.String);
            parameters.Add("@Password", value: model.Password, dbType: DbType.String);

            // 디비 실행
            db.Execute(sql, parameters, commandType: CommandType.Text);
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
            return db.Execute(@"
                Delete AnswersComments Where ArticleId = @ArticleId And Id = @Id And Password = @Password;                 
                Update Answers Set CommentCount = CommentCount - 1 Where Id = @ArticleId;
                "
                , new { ArticleId = articleId, Id = id, Password = password }
                , commandType: CommandType.Text);
        }

        public bool Edit(AnswerComment model)
        {
            throw new NotImplementedException();
        }

        public List<AnswerComment> GetComments(int articleId)
        {
            return db.Query<AnswerComment>(
                "Select * from AnswersComments Where ArticleId = @ArticleId",
                new {ArticleId = articleId},
                commandType : CommandType.Text
                ).ToList();
        }
        /// <summary>
        /// 특정 게시물(ArticleId)의 특정 댓글(Id)에 해당하는 댓글 카운트
        /// </summary>
        /// <param name="articleId"></param>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int GetCountBy(int articleId, int id, string password)
        {
            string sql = "Select Count(*) From AnswersComments Where ArticleId = @ArticleId And Id = @Id And Password = @Password";
            return db.Query<int>(sql, new { ArticleId = articleId, Id = id, Password = password }, commandType: CommandType.Text).SingleOrDefault();
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
