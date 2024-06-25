<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2024)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/DXGrid_PreventGroupRowFromCollapsing/Window1.xaml) (VB: [Window1.xaml](./VB/DXGrid_PreventGroupRowFromCollapsing/Window1.xaml))
* [Window1.xaml.cs](./CS/DXGrid_PreventGroupRowFromCollapsing/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_PreventGroupRowFromCollapsing/Window1.xaml.vb))
<!-- default file list end -->
# How to Prevent Group Rows from being Collapsed


<p>The following example shows how to customize whether a particular group row can be collapsed.</p><p>In this example, the 'Status: Invalidated' group row is prevented from being collapsed, and the full collapsing is disabled. To do this, the GroupRowCollapsing event is handled, and the event parameter's Allow property is set to false when the RowHandle property returns the 'Status: Invalidated' row's handle, or an invalid handle (this happens when all group rows are about to be collapsed).</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-grid-prevent-expand-collapse-operations-for-group-rows&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-grid-prevent-expand-collapse-operations-for-group-rows&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
