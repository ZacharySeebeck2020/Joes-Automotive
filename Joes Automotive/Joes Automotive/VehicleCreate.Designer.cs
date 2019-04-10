namespace Joes_Automotive
{
    partial class VehicleCreate
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
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripBtnSaveExit = new System.Windows.Forms.ToolStripButton();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.date_receivedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_returnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.vehiclesTableAdapter = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.VehiclesTableAdapter();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            date_receivedLabel = new System.Windows.Forms.Label();
            date_returnedLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.customersBindingNavigator.TabIndex = 34;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripBtnSaveExit
            // 
            this.toolStripBtnSaveExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnSaveExit.Image = global::Joes_Automotive.Properties.Resources.save;
            this.toolStripBtnSaveExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveExit.Name = "toolStripBtnSaveExit";
            this.toolStripBtnSaveExit.Size = new System.Drawing.Size(152, 32);
            this.toolStripBtnSaveExit.Text = "Create Vehicle";
            this.toolStripBtnSaveExit.Click += new System.EventHandler(this.ToolStripBtnSaveExit_Click);
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            makeLabel.Location = new System.Drawing.Point(93, 54);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(68, 25);
            makeLabel.TabIndex = 20;
            makeLabel.Text = "Make:";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.makeTextBox.Location = new System.Drawing.Point(167, 51);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(1085, 31);
            this.makeTextBox.TabIndex = 21;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            modelLabel.Location = new System.Drawing.Point(85, 91);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(76, 25);
            modelLabel.TabIndex = 22;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.modelTextBox.Location = new System.Drawing.Point(167, 88);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(1085, 31);
            this.modelTextBox.TabIndex = 23;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            yearLabel.Location = new System.Drawing.Point(104, 128);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(57, 25);
            yearLabel.TabIndex = 24;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.yearTextBox.Location = new System.Drawing.Point(167, 125);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(1085, 31);
            this.yearTextBox.TabIndex = 25;
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            mileageLabel.Location = new System.Drawing.Point(70, 165);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(91, 25);
            mileageLabel.TabIndex = 26;
            mileageLabel.Text = "Mileage:";
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.mileageTextBox.Location = new System.Drawing.Point(167, 162);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(1085, 31);
            this.mileageTextBox.TabIndex = 27;
            // 
            // date_receivedLabel
            // 
            date_receivedLabel.AutoSize = true;
            date_receivedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            date_receivedLabel.Location = new System.Drawing.Point(13, 204);
            date_receivedLabel.Name = "date_receivedLabel";
            date_receivedLabel.Size = new System.Drawing.Size(148, 25);
            date_receivedLabel.TabIndex = 28;
            date_receivedLabel.Text = "Date Received:";
            // 
            // date_receivedDateTimePicker
            // 
            this.date_receivedDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.date_receivedDateTimePicker.Location = new System.Drawing.Point(167, 199);
            this.date_receivedDateTimePicker.Name = "date_receivedDateTimePicker";
            this.date_receivedDateTimePicker.Size = new System.Drawing.Size(1085, 31);
            this.date_receivedDateTimePicker.TabIndex = 29;
            // 
            // date_returnedLabel
            // 
            date_returnedLabel.AutoSize = true;
            date_returnedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            date_returnedLabel.Location = new System.Drawing.Point(11, 241);
            date_returnedLabel.Name = "date_returnedLabel";
            date_returnedLabel.Size = new System.Drawing.Size(150, 25);
            date_returnedLabel.TabIndex = 30;
            date_returnedLabel.Text = "Date Returned:";
            // 
            // date_returnedDateTimePicker
            // 
            this.date_returnedDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.date_returnedDateTimePicker.Location = new System.Drawing.Point(167, 236);
            this.date_returnedDateTimePicker.Name = "date_returnedDateTimePicker";
            this.date_returnedDateTimePicker.Size = new System.Drawing.Size(1085, 31);
            this.date_returnedDateTimePicker.TabIndex = 31;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            notesLabel.Location = new System.Drawing.Point(11, 385);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(66, 25);
            notesLabel.TabIndex = 32;
            notesLabel.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTextBox.Location = new System.Drawing.Point(12, 413);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(1240, 258);
            this.notesTextBox.TabIndex = 33;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // VehicleCreate
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
            this.Name = "VehicleCreate";
            this.Text = "VehicleCreate";
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveExit;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.DateTimePicker date_receivedDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_returnedDateTimePicker;
        private System.Windows.Forms.TextBox notesTextBox;
        private JoesBigBoyDatabaseDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
    }
}