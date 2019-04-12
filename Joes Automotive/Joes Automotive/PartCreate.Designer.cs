namespace Joes_Automotive
{
    partial class PartCreate
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label number_in_stockLabel;
            System.Windows.Forms.Label number_on_orderLabel;
            System.Windows.Forms.Label part_forLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripBtnCreate = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.number_in_stockTextBox = new System.Windows.Forms.TextBox();
            this.number_on_orderTextBox = new System.Windows.Forms.TextBox();
            this.part_forTextBox = new System.Windows.Forms.TextBox();
            this.partsTableAdapter = new Joes_Automotive.JoesBigBoyDatabaseDataSetTableAdapters.PartsTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            number_in_stockLabel = new System.Windows.Forms.Label();
            number_on_orderLabel = new System.Windows.Forms.Label();
            part_forLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(928, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 36);
            this.button1.TabIndex = 37;
            this.button1.Text = "Upload Part Photo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Joes_Automotive.Properties.Resources.tools;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(928, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 319);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = null;
            this.customersBindingNavigator.CountItem = null;
            this.customersBindingNavigator.DeleteItem = null;
            this.customersBindingNavigator.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCreate});
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
            this.customersBindingNavigator.TabIndex = 35;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripBtnCreate
            // 
            this.toolStripBtnCreate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBtnCreate.Image = global::Joes_Automotive.Properties.Resources.save;
            this.toolStripBtnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCreate.Name = "toolStripBtnCreate";
            this.toolStripBtnCreate.Size = new System.Drawing.Size(153, 32);
            this.toolStripBtnCreate.Text = "Save New Part";
            this.toolStripBtnCreate.Click += new System.EventHandler(this.ToolStripBtnCreate_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(98, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(93, 25);
            idLabel.TabIndex = 23;
            idLabel.Text = "Stock ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(197, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(725, 32);
            this.idTextBox.TabIndex = 24;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(76, 79);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(115, 25);
            nameLabel.TabIndex = 25;
            nameLabel.Text = "Part Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(197, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(725, 32);
            this.nameTextBox.TabIndex = 26;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costLabel.Location = new System.Drawing.Point(54, 117);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(137, 25);
            costLabel.TabIndex = 27;
            costLabel.Text = "Cost Per Part:";
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(197, 114);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(725, 32);
            this.costTextBox.TabIndex = 28;
            // 
            // number_in_stockLabel
            // 
            number_in_stockLabel.AutoSize = true;
            number_in_stockLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            number_in_stockLabel.Location = new System.Drawing.Point(19, 155);
            number_in_stockLabel.Name = "number_in_stockLabel";
            number_in_stockLabel.Size = new System.Drawing.Size(172, 25);
            number_in_stockLabel.TabIndex = 29;
            number_in_stockLabel.Text = "Number In Stock:";
            // 
            // number_in_stockTextBox
            // 
            this.number_in_stockTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.number_in_stockTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_in_stockTextBox.Location = new System.Drawing.Point(197, 152);
            this.number_in_stockTextBox.Name = "number_in_stockTextBox";
            this.number_in_stockTextBox.Size = new System.Drawing.Size(725, 32);
            this.number_in_stockTextBox.TabIndex = 30;
            // 
            // number_on_orderLabel
            // 
            number_on_orderLabel.AutoSize = true;
            number_on_orderLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            number_on_orderLabel.Location = new System.Drawing.Point(8, 193);
            number_on_orderLabel.Name = "number_on_orderLabel";
            number_on_orderLabel.Size = new System.Drawing.Size(183, 25);
            number_on_orderLabel.TabIndex = 31;
            number_on_orderLabel.Text = "Number On Order:";
            // 
            // number_on_orderTextBox
            // 
            this.number_on_orderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.number_on_orderTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_on_orderTextBox.Location = new System.Drawing.Point(197, 190);
            this.number_on_orderTextBox.Name = "number_on_orderTextBox";
            this.number_on_orderTextBox.Size = new System.Drawing.Size(725, 32);
            this.number_on_orderTextBox.TabIndex = 32;
            // 
            // part_forLabel
            // 
            part_forLabel.AutoSize = true;
            part_forLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            part_forLabel.Location = new System.Drawing.Point(16, 231);
            part_forLabel.Name = "part_forLabel";
            part_forLabel.Size = new System.Drawing.Size(175, 25);
            part_forLabel.TabIndex = 33;
            part_forLabel.Text = "Model Part Is For:";
            // 
            // part_forTextBox
            // 
            this.part_forTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.part_forTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_forTextBox.Location = new System.Drawing.Point(197, 228);
            this.part_forTextBox.Name = "part_forTextBox";
            this.part_forTextBox.Size = new System.Drawing.Size(725, 32);
            this.part_forTextBox.TabIndex = 34;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // PartCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customersBindingNavigator);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(number_in_stockLabel);
            this.Controls.Add(this.number_in_stockTextBox);
            this.Controls.Add(number_on_orderLabel);
            this.Controls.Add(this.number_on_orderTextBox);
            this.Controls.Add(part_forLabel);
            this.Controls.Add(this.part_forTextBox);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "PartCreate";
            this.Text = "Create a New Part";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripBtnCreate;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox number_in_stockTextBox;
        private System.Windows.Forms.TextBox number_on_orderTextBox;
        private System.Windows.Forms.TextBox part_forTextBox;
        private JoesBigBoyDatabaseDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
    }
}