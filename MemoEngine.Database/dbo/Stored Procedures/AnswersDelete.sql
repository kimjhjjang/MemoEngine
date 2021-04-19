CREATE PROCEDURE [dbo].[AnswersDelete]
	@Id Int,
	@Password NVarChar(255)
AS
-- 등록한암호가 맞는지 확인
	Declare @cnt Int
	Select @cnt = count(*) from Answers
	where Id = Id And Password = @Password

	If @cnt = 0
	Begin
		Return 0
	End

	Declare @Ref Int
	Declare @RefOrder Int
	Declare @AnswerNum Int
	Declare @ParentNum Int

	-- 삭제하려는 글의 정보 읽어오기
	select
	@AnswerNum = AnswerNum, @RefOrder = RefOrder,
	@Ref = Ref, @ParentNum = ParentNum from Answers 
	where Id = @Id

	If @AnswerNum = 0
	Begin
	-- 답변 글이 없으면 바로 삭제
	If @RefOrder> 0
	Begin
	UPDATE Answers SET RefOrder = RefOrder -1 WHERE Ref = @Ref And RefOrder > @RefOrder
	UPDATE Answers SET AnswerNum = AnswerNum -1 WHERE Id = @ParentNum
	END
	Delete Answers Where Id = Id
	Delete Answers WHERE Id = @ParentNum AND ModifyIp = N'((DELETED))' AND AnswerNum = 0
	End
	Else
	Begin
	-- 답변 글이 있으면 삭제 하지 않고 내용만 Null값으로 업데이트
	Update Answers
	Set
		Name = N'(Unknown)' , Email = '', Password = '',
		Title = N'(삭제된 글입니다.)'
		,Content = N'(삭제된 글입니다.)' + N'현재 답변이 포함되어 있기 때문에 내용만 삭제되었습니다.'
		,ModifyIp = N'((DELETED))', FileName = '',
		FileSize = 0, CommentCount = 0
		Where id = @Id
	End
Go
