<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Signup.aspx.cs" Inherits="OtelRezervasyonCodeFirstUI.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link rel="stylesheet" type="text/css" href="Assets/css/main.css">

    <div class="container">
			<div class="row main">
				<div class="panel-heading">
	               <div class="panel-title text-center">
	               		<h1 class="title">Kayıt Olun</h1>
	               		<hr />
	               	</div>
	            </div> 
				<div class="main-login main-center">
					<form class="form-horizontal" method="post" action="#">
						
                        <div class="form-group">
							<label for="username" class="cols-sm-2 control-label">Kullanıcı Adı</label>
							<div class="cols-sm-10">
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-users fa" aria-hidden="true"></i></span>
									<input type="text" class="form-control" name="username" id="txtusername"  placeholder="Kullanıcı adınızı giriniz" runat="server"/>
								</div>
							</div>
						</div>

						<div class="form-group">
							<label for="name" class="cols-sm-2 control-label">İsim</label>
							<div class="cols-sm-10">
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
									<input type="text" class="form-control" name="name" id="txtfirstname"  placeholder="İsminizi giriniz" runat="server"/>
								</div>
							</div>
						</div>

                        <div class="form-group">
							<label for="name" class="cols-sm-2 control-label">Soyisim</label>
							<div class="cols-sm-10">
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
									<input type="text" class="form-control" name="name" id="txtlastname"  placeholder="Soyisminizi giriniz" runat="server"/>
								</div>
							</div>
						</div>

						<div class="form-group">
							<label for="password" class="cols-sm-2 control-label">Parola</label>
							<div class="cols-sm-10">
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
									<input type="password" class="form-control" name="password" id="txtpassword"  placeholder="Parolanızı giriniz" runat="server"/>
								</div>
							</div>
						</div>

						<div class="form-group">
							<label for="confirm" class="cols-sm-2 control-label">Parola Tekrar</label>
							<div class="cols-sm-10">
								<div class="input-group">
									<span class="input-group-addon"><i class="fa fa-lock fa-lg" aria-hidden="true"></i></span>
									<input type="password" class="form-control" name="confirm" id="txtpasswordconfirm"  placeholder="Parolanızı tekrar giriniz" runat="server"/>
								</div>
							</div>
						</div><br />
<asp:Label ID="Label1" runat="server" ForeColor="Red" Visible="False"></asp:Label>


						<div class="form-group ">
							<asp:Button ID="Button1" CssClass="btn btn-primary btn-lg btn-block login-button" runat="server" Text="Kayıt" OnClick="Button1_Click"  />
						</div>
						<div class="login-register">
				            <a href="Login.aspx">Login</a>
				         </div>
					</form>
				</div>
			</div>
		</div>
    <script type="text/javascript" src="Assets/js/bootstrap.js"></script>
</asp:Content>
