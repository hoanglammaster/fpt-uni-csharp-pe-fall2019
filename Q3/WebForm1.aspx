<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <span>ProductName </span>
                <asp:TextBox ID="ProductName" runat="server" CausesValidation="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CK_ProductName" ErrorMessage="ProductName can not be empty!" ControlToValidate="ProductName" runat="server"></asp:RequiredFieldValidator>
            </div>
            <div>
                <span>Supplier </span>
                <asp:DropDownList ID="Supplier" runat="server" Width="227px"></asp:DropDownList>
            </div>
            <div>
                <span>Category </span>
                <asp:DropDownList ID="Category" runat="server" Height="16px" Width="143px"></asp:DropDownList>
            </div>
            <div>
                <span>Quantity per Unit </span>
                <asp:TextBox ID="QuantityPerUnit" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="CK_QuantityPerUnit" ErrorMessage='Quantity per Unit must be in the form of "xxx ml"' ControlToValidate="QuantityPerUnit" ValidationExpression="[1-9][0-9]{2}[ ][m][l]" runat="server" ></asp:RegularExpressionValidator>
            </div>
            <div>
                <span>UnitPrice</span>
                <asp:TextBox ID="UnitPrice" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="CK_UnitPrice"  ErrorMessage="UnitPrice must be an integer number between 10 to 100" ControlToValidate="UnitPrice" MinimumValue="10" MaximumValue="100" runat="server"></asp:RangeValidator>
            </div>
            <div>
                <span>UnitsInStock</span>
                <asp:TextBox ID="UnitsInStock" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CK_UnitsInStock" ErrorMessage="UnitsInStock must be a positive integer number" Operator="DataTypeCheck" ControlToValidate="UnitsInStock" Type="Integer" runat="server"></asp:CompareValidator>
            </div>
            <div>
                <asp:CheckBox ID="Discontinued" Text="Discontinued" runat="server" Checked ="true"/>
            </div>
            <div>
                <asp:Button ID="AddProduct" OnClick="AddProduct_Click" Text="Add Product" runat="server"/>
            </div>
        </div>
    </form>
</body>
</html>
