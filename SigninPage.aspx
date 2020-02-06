<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SigninPage.aspx.cs" Inherits="Online_Book_Shopping_System.SigninPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divForm">
         <h2 class="formTitle">Sign In</h2>
            <div>
                <table>
                    <tr>
                        <td class="labletxt">User Name</td>
                        <td>
                            <asp:TextBox ID="txtUserNameLogin" CssClass="txtField" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="labletxt">Password</td>
                        <td>
                            <asp:TextBox ID="txtPasswordLogin" CssClass="txtField" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr></tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnSignIn" Class="btnsubmit" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />
                        </td>
                    </tr>
                </table>
            </div>
    </div>
</asp:Content>
