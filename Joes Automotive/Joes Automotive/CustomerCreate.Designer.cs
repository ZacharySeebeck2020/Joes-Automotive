namespace Joes_Automotive
{
    partial class CustomerCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label email_addressLabel;
            System.Windows.Forms.Label notesLabel;
            this.joesBigBoyDatabaseDataSet = new Joes_Automotive.JoesBigBoyDatabaseDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripBtnCreateExit = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.email_addressTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            email_addressLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joesBigBoyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(88, 28);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(72, 25);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(69, 57);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(90, 25);
            addressLabel.TabIndex = 15;
            addressLabel.Text = "Address:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_numberLabel.Location = new System.Drawing.Point(5, 83);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(157, 25);
            phone_numberLabel.TabIndex = 17;
            phone_numberLabel.Text = "Phone Number:";
            // 
            // email_addressLabel
            // 
            email_addressLabel.AutoSize = true;
            email_addressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_addressLabel.Location = new System.Drawing.Point(16, 111);
            email_addressLabel.Name = "email_addressLabel";
            email_addressLabel.Size = new System.Drawing.Size(145, 25);
            email_addressLabel.TabIndex = 19;
            email_addressLabel.Text = "Email Address:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(12, 482);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(66, 25);
            notesLabel.TabIndex = 21;
            notesLabel.Text = "Notes";
            // 
            // joesBigBoyDatabaseDataSet
            // 
            this.joesBigBoyDatabaseDataSet.DataSetName = "JoesBigBoyDatabaseDataSet";
            this.joesBigBoyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.joesBigBoyDatabaseDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = null;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = null;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = null;
            this.customersBindingNavigator.DeleteItem = null;
            this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCreateExit});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = null;
            this.customersBindingNavigator.MoveLastItem = null;
            this.customersBindingNavigator.MoveNextItem = null;
            this.customersBindingNavigator.MovePreviousItem = null;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = null;
            this.customersBindingNavigator.Size = new System.Drawing.Size(1264, 35);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripBtnCreateExit
            // 
            this.toolStripBtnCreateExit.Image = global::Joes_Automotive.Properties.Resources.save;
            this.toolStripBtnCreateExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCreateExit.Name = "toolStripBtnCreateExit";
            this.toolStripBtnCreateExit.Size = new System.Drawing.Size(128, 32);
            this.toolStripBtnCreateExit.Text = "Create Customer";
            this.toolStripBtnCreateExit.Click += new System.EventHandler(this.toolStripBtnCreateExit_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(162, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(319, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(162, 64);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(319, 20);
            this.addressTextBox.TabIndex = 16;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(162, 90);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(319, 20);
            this.phone_numberTextBox.TabIndex = 18;
            // 
            // email_addressTextBox
            // 
            this.email_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email_address", true));
            this.email_addressTextBox.Location = new System.Drawing.Point(162, 118);
            this.email_addressTextBox.Name = "email_addressTextBox";
            this.email_addressTextBox.Size = new System.Drawing.Size(319, 20);
            this.email_addressTextBox.TabIndex = 20;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(12, 510);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(1240, 159);
            this.notesTextBox.TabIndex = 22;
            // 
            // CustomerCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(email_addressLabel);
            this.Controls.Add(this.email_addressTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.customersBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerCreate";
            this.Text = "CustomerCreate";
            this.Load += new System.EventHandler(this.CustomerCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesBigBoyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JoesBigBoyDatabaseDataSet joesBigBoyDatabaseDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private JoesBigBoyDatabaseDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripBtnCreateExit;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox email_addressTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
    }
}