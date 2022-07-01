Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace Forbid_Expand_Collapse

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = Invoice.GetData()
        End Sub

        Private Sub OnEndGrouping(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Me.grid.Columns(NameOf(Invoice.Status)).GroupIndex = 0 Then
                Dim childRow = Me.grid.FindRowByValue(Me.grid.Columns(NameOf(Invoice.Status)), InvoiceStatus.Invalidated)
                Dim groupRow = Me.grid.GetParentRowHandle(childRow)
                Me.grid.ExpandGroupRow(groupRow)
                childRow = Me.grid.FindRowByValue(Me.grid.Columns(NameOf(Invoice.Status)), InvoiceStatus.Delivered)
                groupRow = Me.grid.GetParentRowHandle(childRow)
                Me.grid.CollapseGroupRow(groupRow)
            End If
        End Sub

        Private Sub OnGroupRowCollapsing(ByVal sender As Object, ByVal e As RowAllowEventArgs)
            If e.Row IsNot Nothing AndAlso Me.grid.GetGroupRowValue(e.RowHandle).Equals(InvoiceStatus.Invalidated) Then e.Allow = False
        End Sub

        Private Sub OnGroupRowCollapsed(ByVal sender As Object, ByVal e As RowEventArgs)
            If e.Row Is Nothing AndAlso Me.grid.Columns(NameOf(Invoice.Status)).GroupIndex = 0 Then
                Dim childRow = Me.grid.FindRowByValue(Me.grid.Columns(NameOf(Invoice.Status)), InvoiceStatus.Invalidated)
                Dim groupRow = Me.grid.GetParentRowHandle(childRow)
                Me.grid.ExpandGroupRow(groupRow)
            End If
        End Sub

        Private Sub OnGroupRowExpanding(ByVal sender As Object, ByVal e As RowAllowEventArgs)
            If e.Row IsNot Nothing AndAlso Me.grid.GetGroupRowValue(e.RowHandle).Equals(InvoiceStatus.Delivered) Then e.Allow = False
        End Sub

        Private Sub OnGroupRowExpanded(ByVal sender As Object, ByVal e As RowEventArgs)
            If e.Row Is Nothing AndAlso Me.grid.Columns(NameOf(Invoice.Status)).GroupIndex = 0 Then
                Dim childRow = Me.grid.FindRowByValue(Me.grid.Columns(NameOf(Invoice.Status)), InvoiceStatus.Delivered)
                Dim groupRow = Me.grid.GetParentRowHandle(childRow)
                Me.grid.CollapseGroupRow(groupRow)
            End If
        End Sub
    End Class

    Public Class GroupRowTemplateSelector
        Inherits DataTemplateSelector

        Public Property RedRowTemplate As DataTemplate

        Public Property GreenRowTemplate As DataTemplate

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim data As GridGroupValueData = TryCast(item, GridGroupValueData)
            If Equals(data.Text, NameOf(InvoiceStatus.Invalidated)) Then Return RedRowTemplate
            If Equals(data.Text, NameOf(InvoiceStatus.Delivered)) Then Return GreenRowTemplate
            Return MyBase.SelectTemplate(item, container)
        End Function
    End Class
End Namespace
