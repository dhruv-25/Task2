<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageTask.aspx.cs" Inherits="task2.ImageTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:FileUpload ID="fileupload" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox runat="server" ID="ImageName"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsave" OnClick="btnsave_Click" runat="server" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
