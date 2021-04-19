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
	Offset ((@PageNumber - 1 ) * @PageSize) Rows Fetch Next @PageSize Rows Only;
Go