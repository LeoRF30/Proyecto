<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioForm.aspx.cs" Inherits="Proyecto.Pages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login de Usuario</title>
    <link rel="stylesheet" type="text/css" href="../Styles/StyleSheet.css"
</head>
<body>
    <form id="LoginForm" runat="server" method="post">
        <h2>Login de Usuario</h2>
        <label>Nickname:</label>
        <input type="text" id="Nickname" name="nickname" required/><br />

        <label>Contraseña:</label>
        <input type="Password" id="Contrasenna" name="Contrasenna" required/><br />
        
        <input type="submit" value="Login" />

    </form>
</body>
</html>
