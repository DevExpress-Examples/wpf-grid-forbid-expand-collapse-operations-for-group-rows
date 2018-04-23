# How to Prevent Group Rows from being Collapsed


<p>The following example shows how to customize whether a particular group row can be collapsed.</p><p>In this example, the 'Status: Invalidated' group row is prevented from being collapsed, and the full collapsing is disabled. To do this, the GroupRowCollapsing event is handled, and the event parameter's Allow property is set to false when the RowHandle property returns the 'Status: Invalidated' row's handle, or an invalid handle (this happens when all group rows are about to be collapsed).</p>

<br/>


