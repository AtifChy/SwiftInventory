using SwiftInventory.Database;
using System.Windows.Forms;

namespace SwiftInventory.Forms.Main
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, System.EventArgs e)
        {
            UserCountLabel.Text = UserQueries.GetUserCount().ToString();
            ProductCountLabel.Text = ProductQueries.GetProductCount().ToString();
            CustomerCountLabel.Text = CustomerQueries.GetCustomerCount().ToString();
            SupplierCountLabel.Text = SupplierQueries.GetSupplierCount().ToString();
            // CategoriesCountLabel.Text = CategoryQueries.GetCategoryCount().ToString();
            OrdersCountLabel.Text = OrderQueries.GetOrderCount().ToString();
            PurchaseOrdersCountLabel.Text = PurchaseOrderQueries.GetPurchaseOrderCount().ToString();
        }
    }
}
