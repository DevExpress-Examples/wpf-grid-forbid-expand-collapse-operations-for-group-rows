<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128652199/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2024)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataSource.cs](./CS/DXGrid_PreventGroupRowFromCollapsing/DataSource.cs) (VB: [DataSource.vb](./VB/DXGrid_PreventGroupRowFromCollapsing/DataSource.vb))
* [Window1.xaml](./CS/DXGrid_PreventGroupRowFromCollapsing/Window1.xaml) (VB: [Window1.xaml](./VB/DXGrid_PreventGroupRowFromCollapsing/Window1.xaml))
* **[Window1.xaml.cs](./CS/DXGrid_PreventGroupRowFromCollapsing/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_PreventGroupRowFromCollapsing/Window1.xaml.vb))**
<!-- default file list end -->
# How to Prevent Group Rows from being Collapsed


<p>The following example shows how to customize whether a particular group row can be collapsed.</p><p>In this example, the 'Status: Invalidated' group row is prevented from being collapsed, and the full collapsing is disabled. To do this, the GroupRowCollapsing event is handled, and the event parameter's Allow property is set to false when the RowHandle property returns the 'Status: Invalidated' row's handle, or an invalid handle (this happens when all group rows are about to be collapsed).</p>

<br/>


