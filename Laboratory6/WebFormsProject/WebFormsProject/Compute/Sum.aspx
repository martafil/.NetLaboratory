<%@ Page Title="Sum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sum.aspx.cs" Inherits="WebFormsProject.Compute.Sum" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <div class="row">
        <div class="col-md-8">
            <section id="sumingform">
                <div class="form-horizontal">
                    <hr/>
                    <div class="form-group">
                        <div class="col-md-10">
                            <asp:Label runat="server">First Number</asp:Label>
                            <asp:TextBox runat="server" ID="Number1" CssClass="form-control" TextMode="Number"/>
                            <asp:Label runat="server">Secound Number</asp:Label>
                            <asp:TextBox runat="server" ID="Number2" CssClass="form-control" TextMode="Number"/>
                            <asp:Label runat="server">Third Number or Result</asp:Label>
                            <asp:TextBox runat="server" ID="Number3" CssClass="form-control" TextMode="Number"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Number1"
                                                        CssClass="text-danger" ErrorMessage="error"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Number2"
                                                        CssClass="text-danger" ErrorMessage="error"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Number3"
                                                        CssClass="text-danger" ErrorMessage="error"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="SumNumbers" Text="Sum" CssClass="btn btn-default"/>
                        </div>
                    </div>
                </div>
            </section>
        </div>

    </div>
</asp:Content>