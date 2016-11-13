<%@ Page Title="Sum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Compute.aspx.cs" Inherits="WebFormsProject.Compute.Compute" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="row">
        <div class="col-md-8">
            <section id="sumingform">
                <div class="form-horizontal">
                    <hr/>
                    <div class="form-group">
                        <div class="col-md-10">
                            <asp:Label runat="server">Please enter a word</asp:Label>
                            <asp:TextBox runat="server" ID="Word" CssClass="form-control"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Word"
                                                        CssClass="text-danger" ErrorMessage="error"/>
                        </div>
                    </div>
                    <div class="form-group">    
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="Test" Text="Is palindrome?" CssClass="btn btn-default"/>
                            <asp:Label runat="server" ID ="Result"></asp:Label>
                        </div>
                    </div>
                </div>
            </section>
        </div>

    </div>
</asp:Content>