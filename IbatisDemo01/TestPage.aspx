<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="IbatisDemo01.TestPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gdv_list" AutoGenerateColumns="false" runat="server">
        <Columns>
        <asp:TemplateField HeaderText="班级编号">
        <ItemTemplate><%#Eval("Id")%></ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="班级名称">
        <ItemTemplate><%#Eval("Name")%></ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="班级描述">
        <ItemTemplate><%#Eval("Description")%></ItemTemplate>
        </asp:TemplateField>
        </Columns>
        </asp:GridView>
        <br />
        <span>编号：<asp:TextBox ID="txt_tj"  runat="server"></asp:TextBox></span><br />
        <asp:Button ID="btn_sbyid" runat="server" Text="查找是一个实体" 
            onclick="btn_sbyid_Click" /><asp:Button ID="btn_update" runat="server" 
            Text="修改" onclick="btn_update_Click" />
        <br />
        <asp:Label ID="lab_id" runat="server" Text="编号:" Visible="false"></asp:Label><br />
        <asp:TextBox ID="txt_name" runat="server" Visible="false"></asp:TextBox><br />
        <asp:TextBox ID="txt_deci" runat="server" Visible="false"></asp:TextBox><br />
        <asp:Button ID="btn_add" runat="server" Text="添加" onclick="btn_add_Click" />
        <asp:Button
            ID="btn_delete" runat="server" Text="删除" onclick="btn_delete_Click" />
    </div>
    </form>
</body>
</html>
