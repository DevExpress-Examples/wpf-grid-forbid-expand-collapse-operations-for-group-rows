Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports DXExample.DemoData

Namespace DXGrid_PreventGroupRowFromCollapsing

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.gridControl1.ItemsSource = Invoice.GetData()
        End Sub

        Private Sub gridControl1_GroupRowCollapsing(ByVal sender As Object, ByVal e As RowAllowEventArgs)
            If e.Row Is Nothing OrElse CType(e.Row, Invoice).Status = InvoiceStatus.Invalidated AndAlso Me.colStatus.GroupIndex <> -1 Then e.Allow = False
        End Sub
    End Class
End Namespace
