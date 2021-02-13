<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testDriver.aspx.cs" Inherits="IRVT.testDriver" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" 
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>"                     
        
            
            
            SelectCommand="SELECT distinct &quot;PRIME&quot; FROM &quot;WIP_INTERACTIVE_PANEL10&quot;  ORDER BY &quot;PRIME&quot;">
    </asp:SqlDataSource>
        <asp:Label ID="Label2" runat="server" AssociatedControlID="DropDownList1" 
            Text="Prime: "></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="PRIME" DataValueField="PRIME" 
            AutoPostBack="True" ondatabound="DropDownList1_DataBound">

    </asp:DropDownList>
    <br />
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" 
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" 
                                                    
            
            SelectCommand="SELECT ITEM_ID FROM WIP_INTERACTIVE_PANEL10 A WHERE PRIME = :PRIME AND EXISTS (SELECT NULL FROM WIP_INTERACTIVE_PANEL10 WHERE PRIME = A.PRIME AND ITEM_ID = A.ITEM_ID) ORDER BY ITEM_ID">
            <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="PRIME" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
        <asp:Label ID="Label3" runat="server" AssociatedControlID="DropDownList2" 
            Text="ITEM_ID:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" 
        DataSourceID="SqlDataSource2" AutoPostBack="True" DataTextField="ITEM_ID" 
            DataValueField="ITEM_ID" ondatabound="DropDownList2_DataBound">
    </asp:DropDownList>
    <br />
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" 
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" 
                                            
            
            SelectCommand="SELECT VENDOR_CODE FROM WIP_INTERACTIVE_PANEL10 WHERE PRIME = :PRIME AND ITEM_ID = :ITEM_ID ORDER BY VENDOR_CODE">
             <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="PRIME" 
                PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="DropDownList2" Name="ITEM_ID" 
                PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
        <asp:Label ID="Label4" runat="server" AssociatedControlID="DropDownList3" 
            Text="VENDOR_CODE:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList3" runat="server" 
        DataSourceID="SqlDataSource3" DataTextField="VENDOR_CODE" 
            ondatabound="DropDownList3_DataBound" >
    </asp:DropDownList>
    </div>    
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Panel 10" />
    </p>
    <asp:Label ID="Label1" runat="server" Text="IRVT-Test Driver"></asp:Label>
    </form>
</body>
</html>
