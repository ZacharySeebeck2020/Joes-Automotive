namespace Joes_Automotive
{
    partial class VehicleEdit
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
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label date_receivedLabel;
            System.Windows.Forms.Label date_returnedLabel;
            System.Windows.Forms.Label notesLabel;
            this.joesBigBoyDatabaseDataSet = new Joes_Automotive.JoesBigBoyDatabaseDataSet();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.VehiclesTableAdapter();
            this.tableAdapterManager = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.date_receivedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_returnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripBtnSaveExit = new System.Windows.Forms.ToolStripButton();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            date_receivedLabel = new System.Windows.Forms.Label();
            date_returnedLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joesBigBoyDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            makeLabel.Location = new System.Drawing.Point(93, 44);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(68, 25);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            modelLabel.Location = new System.Drawing.Point(85, 81);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(76, 25);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            yearLabel.Location = new System.Drawing.Point(104, 118);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(57, 25);
            yearLabel.TabIndex = 7;
            yearLabel.Text = "Year:";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            mileageLabel.Location = new System.Drawing.Point(70, 155);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(91, 25);
            mileageLabel.TabIndex = 9;
            mileageLabel.Text = "Mileage:";
            // 
            // date_receivedLabel
            // 
            date_receivedLabel.AutoSize = true;
            date_receivedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            date_receivedLabel.Location = new System.Drawing.Point(13, 194);
            date_receivedLabel.Name = "date_receivedLabel";
            date_receivedLabel.Size = new System.Drawing.Size(148, 25);
            date_receivedLabel.TabIndex = 11;
            date_receivedLabel.Text = "Date Received:";
            // 
            // date_returnedLabel
            // 
            date_returnedLabel.AutoSize = true;
            date_returnedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            date_returnedLabel.Location = new System.Drawing.Point(11, 231);
            date_returnedLabel.Name = "date_returnedLabel";
            date_returnedLabel.Size = new System.Drawing.Size(150, 25);
            date_returnedLabel.TabIndex = 13;
            date_returnedLabel.Text = "Date Returned:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(11, 375);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(66, 25);
            notesLabel.TabIndex = 17;
            notesLabel.Text = "Notes";
            // 
            // joesBigBoyDatabaseDataSet
            // 
            this.joesBigBoyDatabaseDataSet.DataSetName = "JoesBigBoyDatabaseDataSet";
            this.joesBigBoyDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.joesBigBoyDatabaseDataSet;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiclesTableAdapter = this.vehiclesTableAdapter;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "make", true));
            this.makeTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.makeTextBox.Location = new System.Drawing.Point(167, 41);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(1085, 31);
            this.makeTextBox.TabIndex = 4;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "model", true));
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.modelTextBox.Location = new System.Drawing.Point(167, 78);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(1085, 31);
            this.modelTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "year", true));
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.yearTextBox.Location = new System.Drawing.Point(167, 115);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(1085, 31);
            this.yearTextBox.TabIndex = 8;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mileageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "mileage", true));
            this.mileageTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.mileageTextBox.Location = new System.Drawing.Point(167, 152);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(1085, 31);
            this.mileageTextBox.TabIndex = 10;
            // 
            // date_receivedDateTimePicker
            // 
            this.date_receivedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_receivedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehiclesBindingSource, "date_received", true));
            this.date_receivedDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.date_receivedDateTimePicker.Location = new System.Drawing.Point(167, 189);
            this.date_receivedDateTimePicker.Name = "date_receivedDateTimePicker";
            this.date_receivedDateTimePicker.Size = new System.Drawing.Size(1085, 31);
            this.date_receivedDateTimePicker.TabIndex = 12;
            // 
            // date_returnedDateTimePicker
            // 
            this.date_returnedDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_returnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehiclesBindingSource, "date_returned", true));
            this.date_returnedDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.date_returnedDateTimePicker.Location = new System.Drawing.Point(167, 226);
            this.date_returnedDateTimePicker.Name = "date_returnedDateTimePicker";
            this.date_returnedDateTimePicker.Size = new System.Drawing.Size(1085, 31);
            this.date_returnedDateTimePicker.TabIndex = 14;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "notes", true));
            this.notesTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(12, 403);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(1240, 258);
            this.notesTextBox.TabIndex = 18;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = null;
            this.customersBindingNavigator.CountItem = null;
            this.customersBindingNavigator.DeleteItem = null;
            this.customersBindingNavigator.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
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
            this.customersBindingNavigator.Size = new System.Drawing.Size(1264, 35);
            this.customersBindingNavigator.Stretch = true;
            this.customersBindingNavigator.TabIndex = 19;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripBtnSaveExit
            // 
            this.toolStripBtnSaveExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSaveExit.Image = global::Joes_Automotive.Properties.Resources.save;
            this.toolStripBtnSaveExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveExit.Name = "toolStripBtnSaveExit";
            this.toolStripBtnSaveExit.Size = new System.Drawing.Size(128, 32);
            this.toolStripBtnSaveExit.Text = "Save && Exit";
            this.toolStripBtnSaveExit.Click += new System.EventHandler(this.ToolStripBtnSaveExit_Click);
            // 
            // VehicleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.customersBindingNavigator);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(date_receivedLabel);
            this.Controls.Add(this.date_receivedDateTimePicker);
            this.Controls.Add(date_returnedLabel);
            this.Controls.Add(this.date_returnedDateTimePicker);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "VehicleEdit";
            this.ShowIcon = false;
            this.Text = "Edit Vehicle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VehicleEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesBigBoyDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JoesBigBoyDatabaseDataSet joesBigBoyDatabaseDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private JoesBigBoyDatabaseDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private JoesBigBoyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.DateTimePicker date_receivedDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_returnedDateTimePicker;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveExit;
    }
}