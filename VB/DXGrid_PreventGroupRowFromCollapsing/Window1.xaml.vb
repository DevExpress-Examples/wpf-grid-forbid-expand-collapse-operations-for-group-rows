Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports DXExample.DemoData

Namespace DXGrid_PreventGroupRowFromCollapsing
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			gridControl1.ItemsSource = Invoice.GetData()
		End Sub
		Private Sub gridControl1_GroupRowCollapsing(ByVal sender As Object, _
				ByVal e As RowAllowEventArgs)
			If e.Row Is Nothing OrElse _
				(CType(e.Row, Invoice)).Status = InvoiceStatus.Invalidated AndAlso _
				colStatus.GroupIndex <> -1 Then
					e.Allow = False
			End If
		End Sub
	End Class
End Namespace
