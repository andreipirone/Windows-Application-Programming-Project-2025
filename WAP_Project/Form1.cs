namespace WAP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
