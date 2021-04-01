CREATE PROCEDURE [dbo].[AnswersDetails]
	@Id int
AS
	-- 조회수 카운트 1증가
	UPDATE Answers SET ReadCount = ReadCount + 1 WHERE Id = @Id

	-- 모든 항목 조회
	Select * from Answers Where Id = @Id
Go
