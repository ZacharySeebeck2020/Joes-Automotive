namespace Joes_Automotive
{
    partial class CustomerEdit
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
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joesBigBoyDatabaseDataSet = new Joes_Automotive.JoesBigBoyDatabaseDataSet();
            this.toolStripBtnSaveExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnViewVehicles = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnViewInvoices = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.email_addressTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.customersTableAdapter = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            email_addressLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joesBigBoyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(102, 56);
            nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(72, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(84, 94);
            addressLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(90, 25);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_numberLabel.Location = new System.Drawing.Point(17, 132);
            phone_numberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(157, 25);
            phone_numberLabel.TabIndex = 7;
            phone_numberLabel.Text = "Phone Number:";
            // 
            // email_addressLabel
            // 
            email_addressLabel.AutoSize = true;
            email_addressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_addressLabel.Location = new System.Drawing.Point(29, 170);
            email_addressLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            email_addressLabel.Name = "email_addressLabel";
            email_addressLabel.Size = new System.Drawing.Size(145, 25);
            email_addressLabel.TabIndex = 9;
            email_addressLabel.Text = "Email Address:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(17, 368);
            notesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(66, 25);
            notesLabel.TabIndex = 11;
            notesLabel.Text = "Notes";
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = null;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = null;
            this.customersBindingNavigator.DeleteItem = null;
            this.customersBindingNavigator.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSaveExit,
            this.toolStripBtnViewVehicles,
            this.toolStripBtnViewInvoices});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = null;
            this.customersBindingNavigator.MoveLastItem = null;
            this.customersBindingNavigator.MoveNextItem = null;
            this.customersBindingNavigator.MovePreviousItem = null;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.customersBindingNavigator.PositionItem = null;
            this.customersBindingNavigator.Size = new System.Drawing.Size(1264, 35);
            this.customersBindingNavigator.Stretch = true;
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.joesBigBoyDatabaseDataSet;
            // 
            // joesBigBoyDatabaseDataSet
            // 
            this.joesBigBoyDatabaseDataSet.DataSetName = "JoesBigBoyDatabaseDataSet";
            this.joesBigBoyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripBtnSaveExit
            // 
            this.toolStripBtnSaveExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSaveExit.Image = global::Joes_Automotive.Properties.Resources.save;
            this.toolStripBtnSaveExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveExit.Name = "toolStripBtnSaveExit";
            this.toolStripBtnSaveExit.Size = new System.Drawing.Size(128, 32);
            this.toolStripBtnSaveExit.Text = "Save && Exit";
            this.toolStripBtnSaveExit.Click += new System.EventHandler(this.toolStripBtnSaveExit_Click);
            // 
            // toolStripBtnViewVehicles
            // 
            this.toolStripBtnViewVehicles.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnViewVehicles.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnViewVehicles.Image = global::Joes_Automotive.Properties.Resources.car;
            this.toolStripBtnViewVehicles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnViewVehicles.Name = "toolStripBtnViewVehicles";
            this.toolStripBtnViewVehicles.Size = new System.Drawing.Size(183, 32);
            this.toolStripBtnViewVehicles.Text = "Customer &Vehicles";
            this.toolStripBtnViewVehicles.Click += new System.EventHandler(this.toolStripBtnViewVehicles_Click);
            // 
            // toolStripBtnViewInvoices
            // 
            this.toolStripBtnViewInvoices.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnViewInvoices.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnViewInvoices.Image = global::Joes_Automotive.Properties.Resources.receipt;
            this.toolStripBtnViewInvoices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnViewInvoices.Name = "toolStripBtnViewInvoices";
            this.toolStripBtnViewInvoices.Size = new System.Drawing.Size(182, 32);
            this.toolStripBtnViewInvoices.Text = "Customer &Invoices";
            this.toolStripBtnViewInvoices.Click += new System.EventHandler(this.toolStripBtnViewInvoices_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(184, 56);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(738, 28);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(184, 94);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(738, 28);
            this.addressTextBox.TabIndex = 6;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(184, 132);
            this.phone_numberTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(738, 28);
            this.phone_numberTextBox.TabIndex = 8;
            // 
            // email_addressTextBox
            // 
            this.email_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email_address", true));
            this.email_addressTextBox.Location = new System.Drawing.Point(184, 170);
            this.email_addressTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.email_addressTextBox.Name = "email_addressTextBox";
            this.email_addressTextBox.Size = new System.Drawing.Size(738, 28);
            this.email_addressTextBox.TabIndex = 10;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(22, 401);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(1228, 266);
            this.notesTextBox.TabIndex = 12;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Joes_Automotive.Properties.Resources.avatar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(930, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 293);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Upload Customer Photo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
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
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CustomerEdit";
            this.Text = "CustomerEdit";
            this.Load += new System.EventHandler(this.CustomerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joesBigBoyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JoesBigBoyDatabaseDataSet joesBigBoyDatabaseDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private JoesBigBoyDatabaseDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox email_addressTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripBtnViewVehicles;
        private System.Windows.Forms.ToolStripButton toolStripBtnViewInvoices;
        private System.Windows.Forms.Button button1;
    }
}