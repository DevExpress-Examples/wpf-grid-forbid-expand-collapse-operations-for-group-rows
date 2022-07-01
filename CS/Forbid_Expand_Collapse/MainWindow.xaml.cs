using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace Forbid_Expand_Collapse {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = Invoice.GetData();
        }

        void OnEndGrouping(object sender, RoutedEventArgs e) {
            if (grid.Columns[nameof(Invoice.Status)].GroupIndex == 0) {
                var childRow = grid.FindRowByValue(grid.Columns[nameof(Invoice.Status)], InvoiceStatus.Invalidated);
                var groupRow = grid.GetParentRowHandle(childRow);
                grid.ExpandGroupRow(groupRow);

                childRow = grid.FindRowByValue(grid.Columns[nameof(Invoice.Status)], InvoiceStatus.Delivered);
                groupRow = grid.GetParentRowHandle(childRow);
                grid.CollapseGroupRow(groupRow);
            }
        }


        void OnGroupRowCollapsing(object sender, RowAllowEventArgs e) {
            if (e.Row != null && grid.GetGroupRowValue(e.RowHandle).Equals(InvoiceStatus.Invalidated))
                e.Allow = false;
        }
        void OnGroupRowCollapsed(object sender, RowEventArgs e) {
            if (e.Row == null && grid.Columns[nameof(Invoice.Status)].GroupIndex == 0) {
                var childRow = grid.FindRowByValue(grid.Columns[nameof(Invoice.Status)], InvoiceStatus.Invalidated);
                var groupRow = grid.GetParentRowHandle(childRow);
                grid.ExpandGroupRow(groupRow);
            }
        }


        void OnGroupRowExpanding(object sender, RowAllowEventArgs e) {
            if (e.Row != null && grid.GetGroupRowValue(e.RowHandle).Equals(InvoiceStatus.Delivered))
                e.Allow = false;
        }
        void OnGroupRowExpanded(object sender, RowEventArgs e) {
            if (e.Row == null && grid.Columns[nameof(Invoice.Status)].GroupIndex == 0) {
                var childRow = grid.FindRowByValue(grid.Columns[nameof(Invoice.Status)], InvoiceStatus.Delivered);
                var groupRow = grid.GetParentRowHandle(childRow);
                grid.CollapseGroupRow(groupRow);
            }
        }
    }

    public class GroupRowTemplateSelector : DataTemplateSelector {
        public DataTemplate RedRowTemplate { get; set; }
        public DataTemplate GreenRowTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            GridGroupValueData data = item as GridGroupValueData;
            if (data.Text == nameof(InvoiceStatus.Invalidated))
                return RedRowTemplate;
            if (data.Text == nameof(InvoiceStatus.Delivered))
                return GreenRowTemplate;
            return base.SelectTemplate(item, container);
        }
    }
}
