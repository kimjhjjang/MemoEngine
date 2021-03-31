-- 게시판용 테이블 설계

CREATE TABLE [dbo].[Answers]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1),

	--5W1H
	Name NVarchar(25) Not null,
	PostDate DateTime Default GetDate(),
	PostIp NVarchar(15) null,
	Title NVarchar(150) Not null,
	Content Nvarchar(Max) Not null,
	Category NVarchar(20) Default('free') null,


	--게시판 주요 컬럼
	Email Nvarchar(100) null,
	Password Nvarchar(255) null,
	ReadCount Int Default 0,
	Encoding Nvarchar(20) null,
	Homepage Nvarchar(100) null,
	ModifyDate DateTime null,
	ModifyIp NVarchar(15) null,
	CommentCount Int Default 0,

	-- 자료실 게시판 관련 주요 컬럼
	FileName NVarchar(255) null,
	FileSize Int Default 0,
	DownCount Int Default 0,

	-- 답변형 게시판 관련 주요 컬럼
	Ref int Not null,
	Step int Default 0,
	RefOrder  int Default 0,
	AnswerNum  int Default 0,
	ParentNum  int Default 0,

	-- 기타 확장 기능 관련 주요 컬럼
	Num Int Null,
	UID Int Null,
	UserId Int Null,
	UserName NVarchar(25) null,
	DvisionId Int Default 0 null,
	CategoryId Int null default 0,
	BoardId Int Null Default 0,
	AplicationId Int Null Default 0
)
Go