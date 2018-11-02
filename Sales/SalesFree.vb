Public Class SalesFree
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Lookupedit()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub Lookupedit()
        LookUpEdit1.Properties.DataSource = SalesOrder.getdata
        LookUpEdit1.Properties.DisplayMember = "Name"
        LookUpEdit1.Properties.ValueMember = "Name"
    End Sub

End Class
