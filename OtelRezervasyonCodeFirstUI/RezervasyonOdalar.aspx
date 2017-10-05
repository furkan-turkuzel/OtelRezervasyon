<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RezervasyonOdalar.aspx.cs" Inherits="OtelRezervasyonCodeFirstUI.RezervasyonOdalar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
   
    <div>
        <asp:Button ID="Button1" runat="server" Text="Önceki Sayfa" OnClick="Button1_Click" style="width:300px;height:50px;background-color:yellow;margin-left:70px;"/>
        <asp:Button ID="Button2" runat="server" Text="Sonraki Sayfa" OnClick="Button2_Click" style="width:300px;height:50px;background-color:yellow;margin-left:630px;" />
    </div>

  <div class="alert alert-success col-md-11" role="alert" style="margin-left:70px;">
     Kalacağınız kişi sayısına göre yeterli oda sayınız : <%=yeterliOdaSayısı %>
  </div>

    <div id="ana" runat="server">

    </div>

    <br /><hr />
    <div class="col-md-11 progress ">
      <div class="progress-bar" role="progressbar" aria-valuenow="50" aria-valuemin="20" aria-valuemax="100" style="width: 50%;">
         <span class="sr-only"></span>
      </div>
    </div>
</asp:Content>
