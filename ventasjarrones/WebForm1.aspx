<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ventasjarrones.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet"/>
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <link href="assets/css/Estilos.css" rel="stylesheet" />
    <title>Loguin</title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="formulario_login" runat="server" method="post" action="@Url.Action()">
                <div class="form-control">
                    <div class="col-md-6 text-center mb-5">
                        <asp:label class="h3" id="lbbienvenida" runat="server" Text="Bienvenido/a al sistema"></asp:label>
                    </div>
                    <div>
                        <asp:Label id="usuario"  runat="server" Text="Usuario:"></asp:Label>
                        <asp:TextBox id="tbusuario" Cssclass="form-control" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                    </div>
                    
                    <div>
                       
                         <asp:Label id="tbpassword" runat="server" Text="Password:"></asp:Label>
                        <asp:TextBox id="tbclave"  Cssclass="form-control" runat="server" placeholder="Password"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button id="Btningar" CssClass="btn btn-primary btn-dark" runat="server" Text="Ingresar" OnClick="Btningar_Click" />
                    </div>
                </div>
                 <a rel="sponsored" class="text-success" href="Actualizar.aspx" target="_blank">¿Olvidaste tu contraseña?</a>
                 </form>
        </div>
    </div>
  
    </body>

</html>
