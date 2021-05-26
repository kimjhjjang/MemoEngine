<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MemoEngine.Answers.Default" %>

<%@ Register Src="~/Answers/Controls/MainSummaryWithThumbNail.ascx" TagPrefix="uc1" TagName="MainSummaryWithThumbNail" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> answers 게시판 프로젝트 </h1>
            
            <uc1:MainSummaryWithThumbNail runat="server" id="MainSummaryWithThumbNail" />
            
        </div>
    </form>
</body>
</html>
