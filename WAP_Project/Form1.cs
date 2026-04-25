using WAP_Project.Model;

namespace WAP_Project
{
    public partial class Form1 : Form
    {
        private List<Shop> shops;
        private long Id;
        public Form1()
        {
            Id = 0;
            shops = new List<Shop>();
            InitializeComponent();
        }

        private void DisplayShops()
        {
            shopListView.Items.Clear();
            foreach (Shop shop in shops)
            {
                ListViewItem listViewItem = new ListViewItem(shop.Name);
                listViewItem.SubItems.Add(shop.Address);
                listViewItem.SubItems.Add(shop.Manager);
                listViewItem.Tag = shop;
                shopListView.Items.Add(listViewItem);
            }
        }

        private void shopNameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(shopNameBox.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider.SetError((Control)sender, "Name is empty!");
            }
        }

        private void shopAddressBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(shopAddressBox.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider.SetError((Control)sender, "Address is empty!");
            }
        }

        private void shopManagerBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(shopManagerBox.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider.SetError((Control)sender, "Manager is empty!");
            }
        }

        private void shopManagerBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void shopAddressBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void shopNameBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void addShopButton_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Id++;
            //try
            //{

            //}
            //catch (Exception ex)
            //{

            //}
            var shop = new Shop(Id, shopNameBox.Text, shopAddressBox.Text, shopManagerBox.Text);
            shops.Add(shop);
            DisplayShops();
        }

        private void shopListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
