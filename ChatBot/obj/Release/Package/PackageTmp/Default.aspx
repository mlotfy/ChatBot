<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChatBot._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row" style="background-color:lightgray">
        <div class="row">
            <div class="col-xs-12 col-sm-12 col-md-4 col-lg-3">
                <img src="images/ntg.PNG" class="img-responsive" />
            </div>
            <div class="col-xs-9 col-sm-12 col-md-8 col-lg-9">
                <h1>NTG Simple Chat bot</h1>
                <p class="lead">Simple Implementation for AIML in .NET</p>
            </div>
        </div>

    </div>

    <div class="row">
        <!--SamplesToBeReplaced-->

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="Panel1"  BorderWidth="1" CssClass="col-xs-12" runat="server" ScrollBars="Auto"  Height="200px">
                </asp:Panel>
                <div class="row">
                    <div class="col-xs-10 col-md-10" >
                        <asp:TextBox ID="TextBox1" CssClass="form-control" Style="max-width:100%!important" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-xs-2 col-md-2">
                        <asp:Button ID="Button1" CssClass="btn btn-success btn-block" runat="server" Text="Send" OnClick="Button1_Click" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

    </div>

</asp:Content>
