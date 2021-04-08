﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/DashboardCore.Master" AutoEventWireup="true" CodeBehind="AnswerIndex.aspx.cs" Inherits="MemoEngine.Answers.AnswerIndex" %>

<%@ Register Src="~/Answers/Controls/AdvancedPagingSingleWithBootstrap.ascx" TagPrefix="uc1" TagName="AdvancedPagingSingleWithBootstrap" %>
<%@ Register Src="~/Answers/Controls/BoardSearchFormSingleControl.ascx" TagPrefix="uc1" TagName="BoardSearchFormSingleControl" %>



<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
    <style>
        .articleList th{
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NaviContent" runat="server">
    <!-- Breadcrumb-->
    <ol class="breadcrumb border-0 m-0">
        <li class="breadcrumb-item">Home</li>
        <li class="breadcrumb-item"><a href="#">Admin</a></li>
        <li class="breadcrumb-item active">QnA 리스트</li>
        <!-- Breadcrumb Menu-->
    </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <%--게시판 리스트 작성 시작--%>
    <div class="row">
        <div class="col-sm-12 col-md-12">
            <div class="card">
                <div class="card-body">
                    <h2 class="text-center">QnA 게시판</h2>
                    <h3>글 목록 - QnA 게시판입니다.</h3>
                    <hr />
                    <table style="margin : 0 auto;" class="col-sm-12 col-md-12">
                        <tr>
                            <td>
                                <div style="font-style: italic; text-align: right; font-size: 8pt;">
                                            Total Record:
                                            <asp:Literal ID="lblTotalRecord" runat="server">1234</asp:Literal>
                                        </div>
                                <%--게시판 그리드--%>
                                <asp:GridView ID="ctlBoardList" runat="server"
                                                AutoGenerateColumns="false"
                                                DataKeyNames="Id"
                                                HeaderStyle-CssClass="text-center"
                                                HeaderStyle-HorizontalAlign="Center"
                                                Width="100%"
                                                CssClass="table table-bordered table-hover table-striped table-condensed articleList">

                                    <Columns>
                                                    <asp:TemplateField HeaderText="번호" HeaderStyle-Width="50px" ItemStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <%# Eval("Id") %>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="분류" HeaderStyle-Width="50px" ItemStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <%# Eval("Category") %>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="제 목" ItemStyle-HorizontalAlign="Left" HeaderStyle-Width="350px">
                                                        <ItemTemplate>
                                                            <%# MemoEngine.Answers.BoardLibrary.FuncStep(Eval("Step")) %>
                                                            <asp:HyperLink ID="lnkTitle" runat="server" NavigateUrl='<%# "AnswerDetails.aspx?Id=" + Eval("Id") %>'>
                                                        <%# MemoEngine.Answers.StringLibrary.CutStringUnicode(Eval("Title").ToString(), 30) %>
                                                            </asp:HyperLink>
                                                            <%# MemoEngine.Answers.BoardLibrary.ShowCommentCount(Eval("CommentCount")) %>
                                                            <%# MemoEngine.Answers.BoardLibrary.FuncNew(Eval("PostDate"))%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="파일" HeaderStyle-Width="70px" ItemStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <%# MemoEngine.Answers.BoardLibrary.FuncFileDownSingle(Convert.ToInt32(Eval("Id")), Eval("FileName").ToString(), Eval("FileSize").ToString(), "Answers") %>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="Name" HeaderText="작성자" HeaderStyle-Width="60px" ItemStyle-HorizontalAlign="Center"></asp:BoundField>
                                                    <asp:TemplateField HeaderText="작성일" ItemStyle-Width="90px" ItemStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <%# MemoEngine.Answers.BoardLibrary.FuncShowTime(Eval("PostDate")) %>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="ReadCount" HeaderText="조회수" ItemStyle-HorizontalAlign="Right" HeaderStyle-Width="60px"></asp:BoundField>
                                                </Columns>
                                </asp:GridView>
                                <%--게시판 그리드--%>
                            </td>
                        </tr>
                        <tr>
                            <td class="text-center">
                                <uc1:AdvancedPagingSingleWithBootstrap runat="server" ID="AdvancedPagingSingleWithBootstrap" />
                            </td>
                        </tr>
                        <tr>
                            <td class="text-right">
                                <a  href="AnswerCreate.aspx" class="btn btn-primary">글쓰기</a>
                            </td>
                        </tr>
                    </table>

                    <uc1:BoardSearchFormSingleControl runat="server" ID="BoardSearchFormSingleControl" />

                </div>
            </div>
        </div>
    </div>

    <%--게시판 리스트 작성 끝--%>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
