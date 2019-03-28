namespace Joes_Automotive
{
    partial class Customer
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
            this.btnLookup = new System.Windows.Forms.Button();
            this.txtLookupId = new System.Windows.Forms.TextBox();
            this.txtOutputAddress = new System.Windows.Forms.TextBox();
            this.txtOutputName = new System.Windows.Forms.TextBox();
            this.txtOutputID = new System.Windows.Forms.TextBox();
            this.btnSaveExit = new System.Windows.Forms.Button();
            this.txtOutputPhoneNum = new System.Windows.Forms.TextBox();
            this.txtOutputEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(59, 160);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(190, 105);
            this.btnLookup.TabIndex = 0;
            this.btnLookup.Text = "&Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // txtLookupId
            // 
            this.txtLookupId.Location = new System.Drawing.Point(59, 113);
            this.txtLookupId.Name = "txtLookupId";
            this.txtLookupId.Size = new System.Drawing.Size(190, 29);
            this.txtLookupId.TabIndex = 1;
            // 
            // txtOutputAddress
            // 
            this.txtOutputAddress.Location = new System.Drawing.Point(685, 113);
            this.txtOutputAddress.Name = "txtOutputAddress";
            this.txtOutputAddress.Size = new System.Drawing.Size(295, 29);
            this.txtOutputAddress.TabIndex = 2;
            // 
            // txtOutputName
            // 
            this.txtOutputName.Location = new System.Drawing.Point(685, 81);
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.Size = new System.Drawing.Size(295, 29);
            this.txtOutputName.TabIndex = 3;
            // 
            // txtOutputID
            // 
            this.txtOutputID.Enabled = false;
            this.txtOutputID.Location = new System.Drawing.Point(685, 37);
            this.txtOutputID.Name = "txtOutputID";
            this.txtOutputID.ReadOnly = true;
            this.txtOutputID.Size = new System.Drawing.Size(71, 29);
            this.txtOutputID.TabIndex = 4;
            // 
            // btnSaveExit
            // 
            this.btnSaveExit.Location = new System.Drawing.Point(685, 261);
            this.btnSaveExit.Name = "btnSaveExit";
            this.btnSaveExit.Size = new System.Drawing.Size(193, 71);
            this.btnSaveExit.TabIndex = 5;
            this.btnSaveExit.Text = "&Save && Exit";
            this.btnSaveExit.UseVisualStyleBackColor = true;
            this.btnSaveExit.Click += new System.EventHandler(this.btnSaveExit_Click);
            // 
            // txtOutputPhoneNum
            // 
            this.txtOutputPhoneNum.Location = new System.Drawing.Point(685, 148);
            this.txtOutputPhoneNum.Name = "txtOutputPhoneNum";
            this.txtOutputPhoneNum.Size = new System.Drawing.Size(295, 29);
            this.txtOutputPhoneNum.TabIndex = 7;
            // 
            // txtOutputEmail
            // 
            this.txtOutputEmail.Location = new System.Drawing.Point(685, 180);
            this.txtOutputEmail.Name = "txtOutputEmail";
            this.txtOutputEmail.Size = new System.Drawing.Size(295, 29);
            this.txtOutputEmail.TabIndex = 6;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 743);
            this.Controls.Add(this.txtOutputPhoneNum);
            this.Controls.Add(this.txtOutputEmail);
            this.Controls.Add(this.btnSaveExit);
            this.Controls.Add(this.txtOutputID);
            this.Controls.Add(this.txtOutputName);
            this.Controls.Add(this.txtOutputAddress);
            this.Controls.Add(this.txtLookupId);
            this.Controls.Add(this.btnLookup);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.TextBox txtLookupId;
        private System.Windows.Forms.TextBox txtOutputAddress;
        private System.Windows.Forms.TextBox txtOutputName;
        private System.Windows.Forms.TextBox txtOutputID;
        private System.Windows.Forms.Button btnSaveExit;
        private System.Windows.Forms.TextBox txtOutputPhoneNum;
        private System.Windows.Forms.TextBox txtOutputEmail;
    }
}