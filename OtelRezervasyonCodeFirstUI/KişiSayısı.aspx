<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="KişiSayısı.aspx.cs" Inherits="OtelRezervasyonCodeFirstUI.Rezervasyonİşlemleri.KişiSayısı" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:50px;">
      <div class="row">
        <div class="col-md-8 col-md-offset-4" >
            <div class="alert alert-warning" role="alert">
               Size en uygun oda seçeneklerini göstermemiz için kalacak kişi sayısını giriniz!!!
            </div>
            <div class="alert alert-danger" role="alert">
                Otelimiz maksimum 60 kişi kapasitelidir!!!
            </div>
        <asp:Label ID="Label1" runat="server" Text="Kalacak kişi sayısı: " Style="background-color:white; height:100px; margin-right:10px;"></asp:Label>
        <asp:TextBox ID="txtkişisayısı" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" ForeColor="Red" Visible="False"></asp:Label>
        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="İlerle" OnClick="Button1_Click" style="margin-left:620px;"/>
            <br /><br /><hr />
            <div class="progress">
              <div class="progress-bar" role="progressbar" aria-valuenow="25" aria-valuemin="0" aria-valuemax="140" style="width: 25%;">
              </div>
           </div>

        </div>
      </div>
    </div>
</asp:Content>
