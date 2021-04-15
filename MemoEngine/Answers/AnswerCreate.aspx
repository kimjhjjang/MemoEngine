<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/DashboardCore.Master" AutoEventWireup="true" CodeBehind="AnswerCreate.aspx.cs" Inherits="MemoEngine.Answers.AnswerCreate" %>

<%@ Register Src="~/Answers/Controls/BoardEditorFormControl.ascx" TagPrefix="uc1" TagName="BoardEditorFormControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NaviContent" runat="server">

    <!-- Breadcrumb-->
          <ol class="breadcrumb border-0 m-0">
            <li class="breadcrumb-item">Home</li>
            <li class="breadcrumb-item"><a href="#">Admin</a></li>
            <li class="breadcrumb-item active">글쓰기</li>
          </ol>
            <!-- Breadcrumb Menu-->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:BoardEditorFormControl runat="server" ID="ctlBoardEditorFormControl" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
