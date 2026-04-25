namespace WAP_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            shopListView = new ListView();
            ColumnName = new ColumnHeader();
            ColumnAddress = new ColumnHeader();
            ColumnManager = new ColumnHeader();
            shopNameBox = new TextBox();
            shopNameLabel = new Label();
            shopAddressBox = new TextBox();
            shopAddressLabel = new Label();
            shopManagerBox = new TextBox();
            shopManagerLabel = new Label();
            addShopButton = new Button();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 23, 23);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 450);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 0;
            label1.Text = "MyCSharpApp";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // shopListView
            // 
            shopListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            shopListView.BackColor = Color.FromArgb(48, 48, 48);
            shopListView.BorderStyle = BorderStyle.None;
            shopListView.Columns.AddRange(new ColumnHeader[] { ColumnName, ColumnAddress, ColumnManager });
            shopListView.ForeColor = Color.White;
            shopListView.FullRowSelect = true;
            shopListView.Location = new Point(193, 173);
            shopListView.MultiSelect = false;
            shopListView.Name = "shopListView";
            shopListView.Size = new Size(482, 265);
            shopListView.TabIndex = 3;
            shopListView.UseCompatibleStateImageBehavior = false;
            shopListView.View = View.Details;
            shopListView.SelectedIndexChanged += shopListView_SelectedIndexChanged;
            // 
            // ColumnName
            // 
            ColumnName.Text = "Name";
            ColumnName.Width = 100;
            // 
            // ColumnAddress
            // 
            ColumnAddress.Text = "Address";
            ColumnAddress.Width = 100;
            // 
            // ColumnManager
            // 
            ColumnManager.Text = "Manager";
            ColumnManager.Width = 100;
            // 
            // shopNameBox
            // 
            shopNameBox.BackColor = Color.FromArgb(48, 48, 48);
            shopNameBox.BorderStyle = BorderStyle.FixedSingle;
            shopNameBox.ForeColor = Color.White;
            shopNameBox.Location = new Point(17, 57);
            shopNameBox.Name = "shopNameBox";
            shopNameBox.Size = new Size(125, 27);
            shopNameBox.TabIndex = 0;
            shopNameBox.Validating += shopNameBox_Validating;
            shopNameBox.Validated += shopNameBox_Validated;
            // 
            // shopNameLabel
            // 
            shopNameLabel.AutoSize = true;
            shopNameLabel.BackColor = Color.Transparent;
            shopNameLabel.ForeColor = Color.FromArgb(189, 193, 198);
            shopNameLabel.Location = new Point(17, 34);
            shopNameLabel.Name = "shopNameLabel";
            shopNameLabel.Size = new Size(49, 20);
            shopNameLabel.TabIndex = 1;
            shopNameLabel.Text = "Name";
            // 
            // shopAddressBox
            // 
            shopAddressBox.BackColor = Color.FromArgb(48, 48, 48);
            shopAddressBox.BorderStyle = BorderStyle.FixedSingle;
            shopAddressBox.ForeColor = Color.White;
            shopAddressBox.Location = new Point(172, 57);
            shopAddressBox.Name = "shopAddressBox";
            shopAddressBox.Size = new Size(125, 27);
            shopAddressBox.TabIndex = 2;
            shopAddressBox.Validating += shopAddressBox_Validating;
            shopAddressBox.Validated += shopAddressBox_Validated;
            // 
            // shopAddressLabel
            // 
            shopAddressLabel.AutoSize = true;
            shopAddressLabel.ForeColor = Color.FromArgb(189, 193, 198);
            shopAddressLabel.Location = new Point(172, 34);
            shopAddressLabel.Name = "shopAddressLabel";
            shopAddressLabel.Size = new Size(62, 20);
            shopAddressLabel.TabIndex = 3;
            shopAddressLabel.Text = "Address";
            // 
            // shopManagerBox
            // 
            shopManagerBox.BackColor = Color.FromArgb(48, 48, 48);
            shopManagerBox.BorderStyle = BorderStyle.FixedSingle;
            shopManagerBox.ForeColor = Color.White;
            shopManagerBox.Location = new Point(327, 57);
            shopManagerBox.Name = "shopManagerBox";
            shopManagerBox.Size = new Size(125, 27);
            shopManagerBox.TabIndex = 4;
            shopManagerBox.Validating += shopManagerBox_Validating;
            shopManagerBox.Validated += shopManagerBox_Validated;
            // 
            // shopManagerLabel
            // 
            shopManagerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            shopManagerLabel.AutoSize = true;
            shopManagerLabel.ForeColor = Color.FromArgb(189, 193, 198);
            shopManagerLabel.Location = new Point(327, 34);
            shopManagerLabel.Name = "shopManagerLabel";
            shopManagerLabel.Size = new Size(68, 20);
            shopManagerLabel.TabIndex = 5;
            shopManagerLabel.Text = "Manager";
            // 
            // addShopButton
            // 
            addShopButton.BackColor = Color.FromArgb(65, 64, 113);
            addShopButton.FlatAppearance.BorderColor = Color.FromArgb(65, 64, 113);
            addShopButton.FlatStyle = FlatStyle.Flat;
            addShopButton.ForeColor = Color.FromArgb(220, 219, 246);
            addShopButton.Location = new Point(17, 105);
            addShopButton.Name = "addShopButton";
            addShopButton.Size = new Size(94, 29);
            addShopButton.TabIndex = 6;
            addShopButton.Text = "Add Shop";
            addShopButton.UseVisualStyleBackColor = false;
            addShopButton.Click += addShopButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(addShopButton);
            groupBox1.Controls.Add(shopManagerLabel);
            groupBox1.Controls.Add(shopManagerBox);
            groupBox1.Controls.Add(shopAddressLabel);
            groupBox1.Controls.Add(shopAddressBox);
            groupBox1.Controls.Add(shopNameLabel);
            groupBox1.Controls.Add(shopNameBox);
            groupBox1.ForeColor = Color.FromArgb(189, 193, 198);
            groupBox1.Location = new Point(193, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 155);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Shop";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(687, 450);
            Controls.Add(shopListView);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private ErrorProvider errorProvider;
        private ListView shopListView;
        private GroupBox groupBox1;
        private Button addShopButton;
        private Label shopManagerLabel;
        private TextBox shopManagerBox;
        private Label shopAddressLabel;
        private TextBox shopAddressBox;
        private Label shopNameLabel;
        private TextBox shopNameBox;
        private ColumnHeader ColumnName;
        private ColumnHeader ColumnAddress;
        private ColumnHeader ColumnManager;
    }
}
