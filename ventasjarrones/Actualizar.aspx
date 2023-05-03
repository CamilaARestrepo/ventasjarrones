<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actualizar.aspx.cs" Inherits="ventasjarrones.Actualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet"/>
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <link href="assets/css/Estilos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
     <div class="wrapper">
        <div class="formcontent">
            <form id="formulario_login" runat="server">
                <div class="form-control">
                    <div class="col-md-6 text-center mb-5">
                        <asp:label class="h3" id="lbbienvenida" runat="server" Text="Recuperar Contraseña"></asp:label>
                    </div>
                    <div>
                        <asp:Label id="c"  runat="server" Text="Correo:"></asp:Label>
                        <asp:TextBox id="tbemail" Cssclass="form-control" runat="server" placeholder="Correo Electronico"></asp:TextBox>
                    </div>
                    
                    <div>
                       
                         <asp:Label id="n" runat="server" Text="Nueva Contraseña:"></asp:Label>
                        <asp:TextBox id="tbcla" Cssclass="form-control" runat="server" placeholder="password"></asp:TextBox>
                    </div>
                      <div>
                       
                         <asp:Label id="Label1" runat="server" Text="Confirmar:"></asp:Label>
                        <asp:TextBox id="tbcla2" Cssclass="form-control" runat="server" placeholder="Confirmar password"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Button id="BtnActu" CssClass="btn btn-primary btn-dark" runat="server" Text="Recuperar" OnClick="BtnActu_Click"  />
                    </div>
                </div>
                 
                 </form>
        </div>
    </div>
</body>
</html>
