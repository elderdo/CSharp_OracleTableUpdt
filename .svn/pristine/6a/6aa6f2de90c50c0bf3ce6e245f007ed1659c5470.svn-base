<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panel10.aspx.cs" Inherits="IRVT.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    &nbsp;<asp:GridView 
        ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" AllowSorting="True" 
        style="margin-bottom: 145px" DataKeyNames="PRIME,ITEM_ID,VENDOR_CODE" onrowdatabound="GridView1_RowDataBound" 
        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:TemplateField HeaderText="PARK  / INDUCT  / KEEP" SortExpression="INDUCT">
                <EditItemTemplate>
                    <asp:DropDownList ID="DropDownList2" runat="server" SelectedValue='<%# Bind("INDUCT") %>'>
                        <asp:ListItem>I</asp:ListItem>  
                        <asp:ListItem>G</asp:ListItem>
                        <asp:ListItem>J</asp:ListItem>
                        <asp:ListItem>K</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:DropDownList ID="DropDownList2" runat="server" 
                        SelectedValue='<%# Bind("INDUCT") %>'>
                        <asp:ListItem>I</asp:ListItem>
                        <asp:ListItem>G</asp:ListItem>
                        <asp:ListItem>J</asp:ListItem>
                        <asp:ListItem>K</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="last_update_dt" 
                DataFormatString="{0:MM-dd-yyyy hh:mm tt}" HeaderText="LAST UPDATE DATE" 
                ReadOnly="True" SortExpression="last_update_dt" />
            <asp:BoundField DataField="ITEM_ID" HeaderText="ITEM_ID" SortExpression="ITEM_ID" 
                ReadOnly="True" />
            <asp:BoundField DataField="PART" HeaderText="PART" 
                SortExpression="PART" ReadOnly="True" />
            <asp:BoundField DataField="PRIME" HeaderText="PRIME" ReadOnly="True" 
                SortExpression="PRIME" />
            <asp:BoundField DataField="NOMENCLATURE" HeaderText="NOMENCLATURE" 
                ReadOnly="True" SortExpression="NOMENCLATURE" />
            <asp:BoundField DataField="QTY" HeaderText="QTY" ReadOnly="True" 
                SortExpression="QTY" DataFormatString="{0:N0}" HtmlEncode="False" 
                NullDisplayText="Null" />
            <asp:BoundField DataField="SC" HeaderText="SC" 
                ReadOnly="True" SortExpression="SC" />
            <asp:BoundField DataField="CRITICALITY" HeaderText="Cr" SortExpression="CRITICALITY" 
                ReadOnly="True" DataFormatString="{0:N0}" HtmlEncode="False" />
            <asp:BoundField DataField="LOCATION" HeaderText="LOCATION" ReadOnly="True" 
                SortExpression="LOCATION" />
            <asp:BoundField DataField="SERIAL" HeaderText="SERIAL" ReadOnly="True" 
                SortExpression="SERIAL" />
            <asp:BoundField DataField="COND" HeaderText="COND" ReadOnly="True" 
                SortExpression="COND" />
            <asp:BoundField DataField="COST_TO_REPAIR_OFF_BASE" 
                HeaderText="COST TO REPAIR&lt;br/&gt;OFF BASE" ReadOnly="True" 
                SortExpression="COST_TO_REPAIR_OFF_BASE" DataFormatString="{0:C}" 
                HtmlEncode="False" NullDisplayText="Null" />
            <asp:BoundField DataField="VENDOR_CODE" HeaderText="VENDOR_CODE" 
                ReadOnly="True" SortExpression="VENDOR_CODE" Visible="False" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
    <asp:Button ID="UpdateButton" runat="server" onclick="UpdateButton_Click" 
        Text="Update" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" 
        onselecting="SqlDataSource1_Selecting" 
        ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" 
        
        SelectCommand="SELECT induct,last_update_dt  + timeZoneHoursOffset last_update_dt,item_id,part,prime,nomenclature,qty,sc,criticality,location,serial,cond,cost_to_repair_off_base,nvl(vendor_code,'NULL') vendor_code FROM &quot;WIP_INTERACTIVE_PANEL10&quot;  WHERE 1 = 1" 
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        UpdateCommand="UPDATE WIP_INTERACTIVE_PANEL10 set INDUCT = trim(:INDUCT), LAST_UPDATE_DT = SYSDATE, UPDATED_BY = :updated_by WHERE  PRIME = :prime AND ITEM_ID = :item_id AND (VENDOR_CODE = :vendor_code or VENDOR_CODE is NULL)">
        <UpdateParameters>

          <asp:ControlParameter ControlID="GridView1" Name="INDUCT" PropertyName="SelectedValue"

            Type="String" DefaultValue="" />

          <asp:ControlParameter ControlID="GridView1" Name="prime" PropertyName="SelectedValue"

            Type="String" />

          <asp:ControlParameter ControlID="GridView1" Name="item_id" PropertyName="SelectedValue"

            Type="String" />

          <asp:ControlParameter ControlID="GridView1" Name="vendor_code" PropertyName="SelectedValue"

            Type="String" />

            <asp:QueryStringParameter DefaultValue="testuser" Name="updated_by" 
                QueryStringField="userid" Type="String" />

        </UpdateParameters>      
        </asp:SqlDataSource>
    <asp:Label ID="StatusLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
