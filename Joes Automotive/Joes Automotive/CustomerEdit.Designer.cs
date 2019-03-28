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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.email_addressTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.toolStripBtnSaveExit = new System.Windows.Forms.ToolStripButton();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joesBigBoyDatabaseDataSet = new Joes_Automotive.JoesBigBoyDatabaseDataSet();
            this.customersTableAdapter = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            email_addressLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joesBigBoyDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = null;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = null;
            this.customersBindingNavigator.DeleteItem = null;
            this.customersBindingNavigator.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSaveExit});
            this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customersBindingNavigator.MoveFirstItem = null;
            this.customersBindingNavigator.MoveLastItem = null;
            this.customersBindingNavigator.MoveNextItem = null;
            this.customersBindingNavigator.MovePreviousItem = null;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.customersBindingNavigator.PositionItem = null;
            this.customersBindingNavigator.Size = new System.Drawing.Size(1264, 28);
            this.customersBindingNavigator.Stretch = true;
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(99, 81);
            nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(72, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(181, 81);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(582, 28);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(81, 136);
            addressLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(90, 25);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(181, 136);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(582, 28);
            this.addressTextBox.TabIndex = 6;
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_numberLabel.Location = new System.Drawing.Point(14, 183);
            phone_numberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(157, 25);
            phone_numberLabel.TabIndex = 7;
            phone_numberLabel.Text = "Phone Number:";
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(181, 183);
            this.phone_numberTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(582, 28);
            this.phone_numberTextBox.TabIndex = 8;
            // 
            // email_addressLabel
            // 
            email_addressLabel.AutoSize = true;
            email_addressLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_addressLabel.Location = new System.Drawing.Point(26, 235);
            email_addressLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            email_addressLabel.Name = "email_addressLabel";
            email_addressLabel.Size = new System.Drawing.Size(145, 25);
            email_addressLabel.TabIndex = 9;
            email_addressLabel.Text = "Email Address:";
            // 
            // email_addressTextBox
            // 
            this.email_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email_address", true));
            this.email_addressTextBox.Location = new System.Drawing.Point(181, 235);
            this.email_addressTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.email_addressTextBox.Name = "email_addressTextBox";
            this.email_addressTextBox.Size = new System.Drawing.Size(582, 28);
            this.email_addressTextBox.TabIndex = 10;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(14, 474);
            notesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(66, 25);
            notesLabel.TabIndex = 11;
            notesLabel.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(14, 504);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(1236, 163);
            this.notesTextBox.TabIndex = 12;
            // 
            // toolStripBtnSaveExit
            // 
            this.toolStripBtnSaveExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSaveExit.Image = global::Joes_Automotive.Properties.Resources.save;
            this.toolStripBtnSaveExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveExit.Name = "toolStripBtnSaveExit";
            this.toolStripBtnSaveExit.Size = new System.Drawing.Size(116, 25);
            this.toolStripBtnSaveExit.Text = "Save && Exit";
            this.toolStripBtnSaveExit.Click += new System.EventHandler(this.toolStripBtnSaveExit_Click);
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
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
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
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CustomerEdit";
            this.Text = "CustomerEdit";
            this.Load += new System.EventHandler(this.CustomerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joesBigBoyDatabaseDataSet)).EndInit();
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
    }
}