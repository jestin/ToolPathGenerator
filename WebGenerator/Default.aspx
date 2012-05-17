<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebGenerator.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="StlFileLabel" runat="server" Text="STL file:"></asp:Label>
        <asp:TextBox ID="StlTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="GenerateButton" runat="server" onclick="GenerateButton_Click" 
            Text="Generate GCode" />
    
    </div>
    <asp:TextBox ID="GCodeTextBox" runat="server" Height="378px" 
        TextMode="MultiLine" Width="1085px"></asp:TextBox>
    </form>
</body>
</html>
