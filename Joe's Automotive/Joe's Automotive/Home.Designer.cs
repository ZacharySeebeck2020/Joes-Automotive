namespace Joe_s_Automotive
{
    partial class Home
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.lblCompName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panelSidebar.Controls.Add(this.lblCompName);
            this.panelSidebar.Controls.Add(this.panel3);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 591);
            this.panelSidebar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(200, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(914, 50);
            this.panelHeader.TabIndex = 1;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelHome.Controls.Add(this.lbl);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(200, 50);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(914, 541);
            this.panelHome.TabIndex = 0;
            // 
            // lblCompName
            // 
            this.lblCompName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompName.Location = new System.Drawing.Point(12, 9);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(179, 83);
            this.lblCompName.TabIndex = 3;
            this.lblCompName.Text = "Joe\'s \r\nAutomotive\r\n";
            this.lblCompName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl.Location = new System.Drawing.Point(6, 3);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(902, 39);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Welcome! Let\'s get started.";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 591);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.MinimumSize = new System.Drawing.Size(1130, 630);
            this.Name = "Home";
            this.Text = "Joe\'s Automotive - Home";
            this.panelSidebar.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCompName;
    }
}

