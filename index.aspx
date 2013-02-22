<%@ Page Language="VB" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Salary Calculator</title>
    <link rel="stylesheet" type="text/css" href="salary_stylesheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 id="Welcome_header"> Welcome to the Salary Calculator! </h1>
        Total hours worked this week:<br />
        <asp:TextBox ID="HoursTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Hourly wage:<br />
        <asp:TextBox ID="WageTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Pre-Tax deductions:<br />
        <asp:TextBox ID="PreTaxTextBox" runat="server"></asp:TextBox>
        %<br />
        <br />
        After-Tax deductions:<br />
        <asp:TextBox ID="AfterTaxTextBox" runat="server"></asp:TextBox>
        %<br />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" BackColor="#99CCFF"></asp:Label>
        <br />
        <br />
        <asp:Button ID="CalculateButton" runat="server" Text="Calculate!" 
            Width="97px" />
&nbsp;&nbsp;
        <asp:Button ID="ClearButton" runat="server" Text="Clear" />
        <br />
        <br />
        <br />
    
    </div>
     <div><h6>All contents &copy; David Manuel Belzer.</h6></div>
    </form>
</body>
</html>
