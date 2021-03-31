-- 댓글 테이블 생성
CREATE TABLE [dbo].[Answers_Comments]
(
 Id Int Identity(1,1) Not null Primary key,
 ArticleId Int Not null,

 -- 5w1H
 Name NVarchar(25) not null,
 PostDate DateTime Default GetDate(),
 PostIp NVarchar(15) null,
 Title Nvarchar(150) null,
 Content Nvarchar(Max) Not null,
 Category Nvarchar(20) Default('free') null,

 --[1] 댓글 관련 주요 컬럼 : 레거시
 Opinion Nvarchar(4000) null,
 BoardName Nvarchar(50) null,
 Password Nvarchar(255) null,

 -- 기타 확장 기능 관련 주요 컬럼
	Num Int Null,
	UserId Int Null,
	CategoryId Int null default 0,
	BoardId Int Null Default 0,
	AplicationId Int Null Default 0
)
go
