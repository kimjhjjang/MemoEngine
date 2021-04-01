CREATE PROCEDURE [dbo].[AnswersList]
	@PageNumber int = 1,
	@PageSize Int = 10
AS
	Select 
	[Id],
	[Name],
	[PostDate],
	[PostIp],
	[Title],
	[Category],
	[ReadCount],
	[FileName],
	[FileSize],
	[DownCount],
	[CommentCount],
	[Step]
	from Answers
	Order By Ref Desc, RefOrder Asc
	Offset ((@pageNumber - 1 ) * @PageSize) Rows Fetch Next @pageSize Rows Only;
Go