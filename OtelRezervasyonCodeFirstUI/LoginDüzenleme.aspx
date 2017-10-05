<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="LoginDüzenleme.aspx.cs" Inherits="OtelRezervasyonCodeFirstUI.LoginDüzenleme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
      <div class="row">
        <div class="col-lg-8 col-md-10 mx-auto">
            
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnDuzenlePanel" runat="server" Text="Bilgileri Düzenle" style="margin-left:100px; color:green;"  />
                        <asp:Button ID="btnSifrePanel" runat="server" Text="Şifreyi Değiştir"  style="margin-left:10px;color:blue;" />
                        <asp:Button ID="btnHesapSilPanel" runat="server" Text="Hesabı Sil" style="margin-left:10px;color:red" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Panel ID="Panel3" runat="server" Visible="False">
                            <table style="width:100%;">
                                <tr>
                                    <td style="text-align: right">
                                        <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı: "></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="text-align: right">
                                        <asp:Label ID="Label2" runat="server" Text="İsim: "></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtisim" runat="server"></asp:TextBox>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="text-align: right">
                                        <asp:Label ID="Label3" runat="server" Text="Soyisim: "></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtsoyisim" runat="server"></asp:TextBox>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="text-align: right"></td>
                                    <td style="text-align: center">
                                        <asp:Button ID="btnGuncelle" runat="server" ForeColor="Green" Text="Güncelle"  />
                                        <asp:Label ID="Label4" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Panel ID="Panel4" runat="server" Visible="False">
                            <table style="width:100%;">
                                <tr>
                                    <td style="text-align: right">
                                        <asp:Label ID="Label5" runat="server" Text="Parola: "></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtparola" runat="server"></asp:TextBox>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="text-align: right">
                                        <asp:Label ID="Label6" runat="server" Text="Parola Tekrar: "></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtparolatekrar" runat="server"></asp:TextBox>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td style="text-align: center">
                                        <asp:Button ID="btnDegistir" runat="server" ForeColor="Blue" Text="Değiştir"  />
                                        <asp:Label ID="Label7" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            
        </div>
      </div>
    </div>

</asp:Content>
