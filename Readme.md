<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128652199/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2024)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - Prevent Expand and Collapse Operations for Group Rows

The following example prevents users from collapsing the **Status: Invalidated** group row and expanding the **Status: Delivered** group row.

![image](https://user-images.githubusercontent.com/65009440/176848239-7e773d46-7a49-44fc-9d36-c8fe564e83e7.png)

* The [GridControl.EndGrouping](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.EndGrouping) event handler initially expands/collapses group rows when a user groups the grid against the **Status** column.
* The [GridControl.GroupRowCollapsing](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.GroupRowCollapsing) event handler prevents the collapse of the **Status: Invalidated** group row when a user clicks the expand button.
* The [GridControl.GroupRowCollapsed](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.GroupRowCollapsed) event handler retains the **Status: Invalidated** group row's expanded state when a user clicks the **Full Collapse** context menu item.
* The [GridControl.GroupRowExpanding](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.GroupRowExpanding) event handler prevents the expansion of the **Status: Delivered** group row when a user clicks the expand button.
* The [GridControl.GroupRowExpanded](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.GroupRowExpanded) event handler retains the **Status: Delivered** group row's collapsed state when a user clicks the **Full Expand** context menu item.

## Files to Look at

* [MainWindow.xaml](./CS/Forbid_Expand_Collapse/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Forbid_Expand_Collapse/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/Forbid_Expand_Collapse/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Forbid_Expand_Collapse/MainWindow.xaml.vb))

## Documentation

* [Group Data](https://docs.devexpress.com/WPF/7357/controls-and-libraries/data-grid/grouping)
* [Process Group Rows](https://docs.devexpress.com/WPF/6140/controls-and-libraries/data-grid/grouping/processing-group-rows)
* [End-User Capabilities -> Grouping](https://docs.devexpress.com/WPF/6216/controls-and-libraries/data-grid/end-user-capabilities/grouping)

## More Examples

* [WPF Data Grid - How to Apply Custom Rules to Group Rows](https://github.com/DevExpress-Examples/how-to-implement-custom-grouping-e1530)
* [WPF Data Grid - Sort Group Rows by Summary Values](https://github.com/DevExpress-Examples/how-to-sort-group-rows-by-summary-values-e1540)
