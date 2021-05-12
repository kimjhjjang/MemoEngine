<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard/DashboardCore.Master" AutoEventWireup="true" CodeBehind="AnswerDetails.aspx.cs" Inherits="MemoEngine.Answers.AnswerDetails" %>

<%@ Register Src="~/Answers/Controls/BoardCommentControl.ascx" TagPrefix="uc1" TagName="BoardCommentControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NaviContent" runat="server">
    <!-- Breadcrumb-->
          <ol class="breadcrumb border-0 m-0">
            <li class="breadcrumb-item">Home</li>
            <li class="breadcrumb-item"><a href="#">Admin</a></li>
            <li class="breadcrumb-item active">글상세</li>
            <!-- Breadcrumb Menu-->
          </ol>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <div class="animated fadeIn">

            <%--게시판 상세보기 작성 시작--%>
            <div class="row">
                <div class="col-sm-12 col-md-12">
                    <div class="card">
                        <div class="card-body">

                            <h2 class="text-center">Q&amp;A 게시판</h2>
                            <h4>글 상세보기 페이지 </h4>
                            <hr />

                            <table style="width: 700px; margin-left: auto; margin-right: auto;">
                                <tbody>
                                    <tr style="color: white; background-color: #46698c;">
                                        <td style="width: 80px; text-align: right; height: 35px;">
                                            <b style="font-size: 18px">제 목</b> :
                                        </td>
                                        <td colspan="3">
                                            <asp:Label ID="lblTitle" Font-Bold="True" Font-Size="18px" Width="100%" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr style="background-color: #efefef;">
                                        <td class="text-right">번 호 :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblNum" Width="84" runat="server"></asp:Label>
                                        </td>
                                        <td class="text-right">E-mail :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblEmail" Width="100%" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr style="background-color: #efefef;">
                                        <td class="text-right">이 름 :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblName" Width="100%" runat="server"></asp:Label>
                                        </td>
                                        <td class="text-right">Homepage :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblHomepage" Width="100%" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr style="background-color: #efefef;">
                                        <td class="text-right">작성일 :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblPostDate" Width="100%" runat="server"></asp:Label></td>
                                        <td class="text-right">IP 주소 :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblPostIp" Width="100%" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr style="background-color: #efefef;">
                                        <td class="text-right">조회수 :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblReadCount" Width="100%" runat="server"></asp:Label>
                                        </td>
                                        <td class="text-right">파일 :
                                        </td>
                                        <td>
                                            <asp:Label ID="lblFile" Width="100%" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="padding: 10px;">
                                            <div class="text-center">
                                                <asp:Literal ID="ltrImage" runat="server"></asp:Literal>
                                            </div>
                                            <asp:Label ID="lblContent" runat="server" Width="100%" Height="115px"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4">
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4">
                                            <!-- 댓글 관리 폼 시작 -->
                                            <uc1:BoardCommentControl runat="server" ID="BoardCommentControl" />
                                            <!-- 댓글 관리 폼 종료 -->
                                        </td>
                                    </tr>
                                </tbody>
                            </table>

                            <div style="text-align: center;">
                                <asp:HyperLink ID="lnkDelete" runat="server" CssClass="btn btn-primary">삭제</asp:HyperLink>
                                <asp:HyperLink ID="lnkModify" runat="server" CssClass="btn btn-primary">수정</asp:HyperLink>
                                <asp:HyperLink ID="lnkReply" runat="server" CssClass="btn btn-primary">답변</asp:HyperLink>
                                <asp:HyperLink ID="lnkList" runat="server" NavigateUrl="AnswerIndex.aspx" CssClass="btn btn-primary">리스트</asp:HyperLink>
                            </div>

                            <asp:Label ID="lblError" runat="server" ForeColor="Red" EnableViewState="False"></asp:Label>
                            <br />

                        </div>
                    </div>
                </div>
                <!-- /.col-->
            </div>
            <%--게시판 상세보기 작성 종료--%>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
