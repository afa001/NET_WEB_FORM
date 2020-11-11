<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Documents.aspx.cs" Inherits="CRUD_NET_WEB_FORM_EF.View.Documents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <p>
           Nombre:
           <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
       </p>        
        <p>
           <asp:Button ID="btnSave" runat="server" OnClick="btnSaveOnclick" Text="Guardar"/>
        </p>
         <asp:GridView ID="gvDocuments" runat="server">
        </asp:GridView>
    </form>
</body>
</html>